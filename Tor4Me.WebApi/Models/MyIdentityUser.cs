using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace Tor4Me.WebApi.Models
{
    public class MyIdentityUser:IdentityUser
    {
        public virtual long BusinessID { get; set; }
    }
}