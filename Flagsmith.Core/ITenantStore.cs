﻿using Flagsmith.Core.Models;

namespace Flagsmith.Core;

public interface ITenantStore
{
    Task<IEnumerable<Tenant>> GetAllTenantsAsync();
}