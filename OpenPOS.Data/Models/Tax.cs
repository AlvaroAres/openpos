﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPOS.Data.Models
{
    public class Tax
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
    }
}
