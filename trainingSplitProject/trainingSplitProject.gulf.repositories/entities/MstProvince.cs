using System;
using System.Collections.Generic;

namespace trainingSplitProject.gulf.repositories.entities
{
    public partial class MstProvince
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
