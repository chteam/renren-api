using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenRen
{
   internal class MockRenRenHandler:IRenRenHandler
    {
       public RenRenApi Api
       {
           get;
           set;
       }

       public bool IsDebug
       {
           get;
           set;
       }

       public string UserID
       {
           get;
           set;
       }
    }
}
