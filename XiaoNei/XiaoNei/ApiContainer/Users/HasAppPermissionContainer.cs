using System.Xml.Serialization;

namespace RenRen.ApiContainer
{
    [XmlRoot("users_hasAppPermission_response", Namespace = "http://api.renren.com/1.0/")]
    public class HasAppPermissionContainer
    {
        [XmlText(typeof(bool))]
        public bool Has { get; set; }
    }
}