using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trainingSplitProject.gulf.model
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
