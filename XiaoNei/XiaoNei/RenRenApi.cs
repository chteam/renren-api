﻿using System.Text;
using System.Web;
using RenRen.Api;
using System.Collections.Generic;
using RenRen.ApiContainer;

namespace RenRen
{
    public class RenRenApi
    {
        //http://apps.renren.com/iloveyourhome/?origin=903&
        //xn_sig_in_iframe=1
        //&xn_sig_method=get
        //&xn_sig_time=1244437143581
        //&xn_sig_added=1
        //&xn_sig_user=45102821
        //&xn_sig_session_key=2.f3499092760dc4350271386376475612.3600.1244440800-45102821
        //&xn_sig_expires=0
        //&xn_sig_api_key=7b4862666bad4eccb1f9053048b23428
        //&xn_sig_app_id=31802
        //&xn_sig_in_iframe=1
        public RenRenApi(string apiKey, string secret, string sessionKey,IRenRenHandler handler)
        {
            //HttpContext = httpContext;
            Cache = new Dictionary<string, string>();
            ApiKey = new KeyValuePair<string, string>("api_key", apiKey);
            Secret = secret;
            Version = new KeyValuePair<string, string>("v", "1.0");
            SessionKey = new KeyValuePair<string, string>("session_key", sessionKey);
            Handler = handler;
            //PostData = string.Format("api_key={0}&session_key={1}&v={2}", ApiKey, Secret, Version);
        }
        public RenRenApi(string apiKey, string secret, string sessionKey)
            : this(apiKey, secret, sessionKey, new MockRenRenHandler())
        {
        }
      // public  HttpContextBase HttpContext { get; set; }

        public bool CanPay;
        public IRenRenHandler Handler { get; set; }
        public KeyValuePair<string, string> Version { get; set; }
        public KeyValuePair<string, string> ApiKey { get; set; }
        public KeyValuePair<string, string> SessionKey { get; set; }

        public string Secret { get; set; }
        const string ApiUrl = "http://api.renren.com/restserver.do";

        IDictionary<string, string> Cache { get; set; }
        public string Proc(string param)
        {
            if (!Cache.ContainsKey(param))
            {
                var proc = new HttpProc(ApiUrl) { StrPostdata = param, Encoding = Encoding.UTF8 };
                string ret = proc.Proc();
                Cache.Add(param, ret);
            }
            if (Cache[param].Contains("error_response"))
            {
                var message = Cache[param];
                Cache.Remove(param);
                var error = this.Load<ErrorContainer>(message);
                throw new ResponseException(error.Message);
            }
            return Cache[param];
        }
        public string Proc(IDictionary<string,string> dict)
        {
            return Proc(dict.ToQueryString(this));
        }
        #region XiaoNeiApi
        Users _users;
        public Users Users
        {
            get
            {
                if (_users == null)
                    _users = new Users(this);
                return _users;
            }
        }
        Profile _profile;
        public Profile Profile
        {
            get
            {
                if (_profile == null)
                    _profile = new Profile(this);
                return _profile;
            }
        }
        Friends _friends;
        public Friends Friends
        {
            get
            {
                if (_friends == null)
                    _friends = new Friends(this);
                return _friends;
            }
        }
        Feed _feed;
        public Feed Feed
        {
            get
            {
                if (_feed == null)
                    _feed = new Feed(this);
                return _feed;
            }
        }
        Notifications _notifications;
        public Notifications Notifications
        {
            get
            {
                if (_notifications == null)
                    _notifications = new Notifications(this);
                return _notifications;
            }
        }
        Invitations _invitations;
        public Invitations Invitations
        {
            get
            {
                if (_invitations == null)
                    _invitations = new Invitations(this);
                return _invitations;
            }
        }		
        Admin _admin;
        public Admin Admin
        {
            get
            {
                if (_admin == null)
                    _admin = new Admin(this);
                return _admin;
            }
        }
        Pay _pay;
        private string apiKey;
        private string sessionKey;
        private MockRenRenHandler mockRenRenHandler;
        public Pay Pay
        {
            get
            {
                if (_pay == null)
                    _pay = new Pay(this);
                return _pay;
            }
        }
        #endregion

        #region Init
        public static RenRenApi GetInstanceByHttpContext(IRenRenHandler ih, HttpContextBase httpContext, string secret)
        {
            ih.IsDebug = false;
            var sessionKey = httpContext.Request.QueryString["xn_sig_session_key"];
            sessionKey = httpContext.Server.UrlEncode(sessionKey);
            var apiKey = httpContext.Request.QueryString["xn_sig_api_key"];
            return new RenRenApi(apiKey, secret, sessionKey, ih);
        }

        #endregion
    }
}
