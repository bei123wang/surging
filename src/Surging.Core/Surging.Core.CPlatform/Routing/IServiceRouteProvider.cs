﻿using Surging.Core.CPlatform.Routing;
using System.Threading.Tasks;

namespace Surging.Core.CPlatform.Routing
{
    public interface IServiceRouteProvider
    {
        Task<ServiceRoute> Locate(string serviceId);

        ValueTask<ServiceRoute> GetRouteByPath(string path);
    }
}
