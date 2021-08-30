﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hair_Dressing_Appointments_MVC.Models
{
    public class Client
    {
        //Client details
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string MobilePhoneNumber { get; set; }
    }
}
