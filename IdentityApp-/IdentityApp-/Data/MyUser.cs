
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp_.Data
{
    public class MyUser:IdentityUser
    {
        public int Age { get; set; }
        public string City { get; set; }

    }
}
