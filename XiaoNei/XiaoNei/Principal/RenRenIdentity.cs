using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace RenRen
{
    public class RenRenIdentity : IIdentity
    {
        public string AuthenticationType
        {
            get { return "renren"; }
        }

        public bool IsAuthenticated
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public long UserId { get; set; }
        public string FaceUrl { get; set; }
    }
}
