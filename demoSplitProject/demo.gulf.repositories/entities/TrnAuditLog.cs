using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnAuditLog
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string EventName { get; set; }
        public string ActionBy { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Message { get; set; }
    }
}
