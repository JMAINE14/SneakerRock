﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerRockMVC.Models
{
    public class ColorWay
    {
        public string Name { get; set; }
        public int ID { get; set; }


        public int StyleID { get; set; }
        public Style Style { get; set; }

        public IList<Sneaker> Sneakers { get; set; }
    }
}
