﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tor4Me.Data;

namespace Tor4Me.Services.Services
{
   public interface IServiceAndExecuterService
    {
        List<service_executers> GetServiceExecutersByBusIdAndExeId(int busid, int exeid);
    }
}
