using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstProvince
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
