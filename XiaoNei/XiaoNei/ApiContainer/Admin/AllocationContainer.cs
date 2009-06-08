using System;
using System.Xml.Serialization;

namespace XiaoNei.ApiContainer.Admin
{
    /// <summary>
    /// <?xml version="1.0" encoding="UTF-8"?> 
    /// <admin_getAllocation_response 
    /// xmlns=http://api.xiaonei.com/1.0/ 
    /// xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance 
    /// list="true" 
    /// xsi:schemaLocation=http://api.xiaonei.com/1.0/ http://api.xiaonei.com/1.0/xiaonei.xsd>  
    /// <notifications_per_day>158422</notifications_per_day>  
    /// <requests_per_day>1000</requests_per_day> 
    /// </admin_getAllocation_response>
    /// </summary>
    [XmlRoot("admin_getAllocation_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public class AllocationContainer
    {
        /// <summary>
        /// 表示一个用户当天可以发送通知的配额
        /// </summary>
        [XmlElement("notifications_per_day", typeof(int))]
        public int NotificationsPerDay { get; set; }
        /// <summary>
        /// 表示一个用户当天可以发送应用邀请的配额
        /// </summary>
        [XmlElement("requests_per_day", typeof(int))]
        public int RequestsPerDay { get; set; }
    }
   
}