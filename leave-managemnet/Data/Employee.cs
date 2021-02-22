﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managemnet.Data
{
    public class Employee : IdentityUser
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public int TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateJoined { get; set; }
      
    }
}