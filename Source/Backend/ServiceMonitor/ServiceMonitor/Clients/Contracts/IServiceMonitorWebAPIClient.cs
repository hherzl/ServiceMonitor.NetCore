﻿using System.Net.Http;
using System.Threading.Tasks;
using ServiceMonitor.Clients.DataContracts;

namespace ServiceMonitor.Clients.Contracts
{
    public interface IServiceMonitorWebAPIClient
    {
        Task<ServiceWatchResponse> GetServiceWatcherItemsAsync();

        Task<HttpResponseMessage> PostServiceEnvironmentStatusLog(ServiceStatusLogRequest request);
    }
}
