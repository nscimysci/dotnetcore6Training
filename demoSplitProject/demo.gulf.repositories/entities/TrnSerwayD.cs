using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnSerwayD
    {
        public int SerwayDid { get; set; }
        public int? SerwayHid { get; set; }
        public int? ListId { get; set; }
        public string ListRole { get; set; }
        public string SerwayBy { get; set; }
        public string Answers { get; set; }
        public DateTime? SerwayDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
