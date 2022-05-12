using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnActionHistory
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string EventName { get; set; }
        public string ActionBy { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Message { get; set; }
        public int? ProcessId { get; set; }
    }
}
