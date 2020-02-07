﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerRockMVC.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public IList<BrandName> BrandNames { get; set; }


    }
}
