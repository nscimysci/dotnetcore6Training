using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnSuportToken
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Tokenstring { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
