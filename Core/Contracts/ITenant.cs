using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface ITenant
    {
        public string TenantId { get; set; }
        
    }
}
