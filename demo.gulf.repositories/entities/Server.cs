﻿using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class Server
    {
        public string Id { get; set; }
        public string Data { get; set; }
        public DateTime LastHeartbeat { get; set; }
    }
}
