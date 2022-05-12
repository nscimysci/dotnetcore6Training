﻿using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstExchangRate
    {
        public int ExchId { get; set; }
        public string Exchange { get; set; }
        public decimal Rate { get; set; }
        public DateTime ExchDate { get; set; }
        public int? ExchOrderBy { get; set; }
    }
}
