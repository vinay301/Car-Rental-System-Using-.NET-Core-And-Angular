﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Net.Models.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string Client_URL { get; set; }
    }
}