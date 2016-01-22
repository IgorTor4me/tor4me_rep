using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tor4Me.Data;
using Tor4Me.Data.DTOs; 
using Tor4Me.services;
using Tor4Me.services.Services;

namespace Tor4Me.WebApi.Controllers
{
    [RoutePrefix("api/example")]
    public class exampleController : ApiController  
    {
        private DB_9EED4C_tor4meserverEntities db = new DB_9EED4C_tor4meserverEntities();

        [Route("")]
        public bool Post(ModelExample ModelExample)
        {
            try
            {
              //  db.executers.Add(ModelExample);
               // db.SaveChanges();
                Console.WriteLine(ModelExample.exename);
                Console.WriteLine(ModelExample.servid);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
