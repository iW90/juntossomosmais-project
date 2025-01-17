﻿using JSMClientsRegistries.Core.Entities;
using JSMClientsRegistries.Core.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JSMClientsRegistries.Core.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<IEnumerable<Client>> ElegibleList(ClientRegionEnum region, ClientTypeEnum type, int pageNumber, int pageSize);
        Task<int> CountElegibleList(ClientRegionEnum region, ClientTypeEnum type);

        Task<Client> LastId();
    }
}
