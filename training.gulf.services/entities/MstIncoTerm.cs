using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstIncoTerm
    {
        public int IncoTermId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
