using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace RenRen
{
    public class RenRenPrincipal : IPrincipal
    {
        public RenRenPrincipal(long userId, string name, string faceUrl)
        {
            Identity = new RenRenIdentity()
            {
                Name = name,
                FaceUrl = faceUrl,
                UserId = userId,
                IsAuthenticated = true
            };
        }
        public IIdentity Identity
        {
            get;
            private set;
        }

        public bool IsInRole(string role)
        {
            return false;
        }
    }
}
