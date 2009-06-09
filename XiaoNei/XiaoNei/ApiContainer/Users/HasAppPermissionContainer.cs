using System.Xml.Serialization;

namespace XiaoNei.ApiContainer
{
    [XmlRoot("users_hasAppPermission_response", Namespace = "http://api.xiaonei.com/1.0/")]
    public class HasAppPermissionContainer
    {
        [XmlText(typeof(bool))]
        public bool Has { get; set; }
    }
}