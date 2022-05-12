using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class MstProvince
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; }
        public bool IsActive { get; set; }
    }
}
