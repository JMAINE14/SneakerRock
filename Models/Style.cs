using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerRockMVC.Models
{
    public class Style
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public int BrandNameID { get; set; }
        public BrandName BrandName { get; set; }

        public IList<ColorWay> ColorWays { get; set; }
    }
}
