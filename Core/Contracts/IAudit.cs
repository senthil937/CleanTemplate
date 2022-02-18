using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    interface IAudit
    {
        public DateTime? CreatedDate { get; set; }
        public  string CreatedBy { get; set; }
        public  DateTime? UpdatedDate { get; set; }
        public  string UpdatedBy { get; set; }
    }
}
