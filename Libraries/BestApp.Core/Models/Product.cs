﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestApp.Core.Models
{
    public class Product:Entity
    {
        public string Name { get; set; }
        public int price { get; set; }
    }
}
