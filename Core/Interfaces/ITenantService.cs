using System;
using System.Collections.Generic;
using System.Text;
using Core.Options;
namespace Core.Interfaces
{
    public interface ITenantService
    {
        public string GetDatabaseProvider();
        public string GetConnectionString();
        public Tenant GetTenant();
    }
}
