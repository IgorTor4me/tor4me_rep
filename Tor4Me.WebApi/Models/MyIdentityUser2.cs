using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tor4Me.WebApi.Models
{
     partial class MyIdentityUser2 : MyIdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>, IUser, IUser<string>
    {
        // Summary:
        //     Constructor which creates a new Guid for the Id
        public MyIdentityUser2();
        //
        // Summary:
        //     Constructor that takes a userName
        //
        // Parameters:
        //   userName:
        public MyIdentityUser2(string userName);
    }
}