using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tor4Me.Data;
using System.Data.Entity;

namespace Tor4Me.Services.Services
{
    public class ServiceAndExecuterService : IServiceAndExecuterService
    {
        private DB_9EED4C_tor4meserverEntities db = new DB_9EED4C_tor4meserverEntities();
        public List<service_executers> GetServiceExecutersByBusIdAndExeId(int busid,int exeid)
        {
            return db.service_executers.Where(x => x.sexbusid == busid)
                                .Where(x => x.sexexeid == exeid).ToList();
        }


    }
}