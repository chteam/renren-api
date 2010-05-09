using System;
using System.Collections.Generic;

using System.Text;

namespace RenRen.Api
{
    public class ApiBase
    {
        public ApiBase(RenRenApi api)
        {
            Api = api;
        }
        protected RenRenApi Api { set; get; }

        protected IDictionary<string, string> CreateDictionary(string method, bool hasSessionKey)
        {
            IDictionary<string, string> dict = new Dictionary<string, string>
                                                   {
                                                       {"method", method},
                                                       {"call_id", DateTime.Now.Millisecond.ToString()}
                                                   };
            dict.Add(Api.ApiKey);
            dict.Add(Api.Version);
            if (hasSessionKey)
                dict.Add(Api.SessionKey);
            return dict;
        }
        protected IDictionary<string, string> CreateDictionary(string method)
        {
            return CreateDictionary(method, false);
        }
    }
}
