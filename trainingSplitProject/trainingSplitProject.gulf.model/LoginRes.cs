using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trainingSplitProject.gulf.model
{
    public class LoginRes
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}
