using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tor4Me.Data;
using Tor4Me.Services.Services;

namespace Tor4Me.WebApi.Controllers
{
    public class service_executersController : ApiController
    {
        private IServiceAndExecuterService ServiceAndExecuter = new ServiceAndExecuterService();


        [Route("business/{busid}")]
        public IEnumerable<service_executers> GetByExeId(int busid, int exeid)
        {
            return ServiceAndExecuter.GetServiceExecutersByBusIdAndExeId(busid, exeid);
        }

    }
}
