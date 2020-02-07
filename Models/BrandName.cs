using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerRockMVC.Models
{
    public class BrandName
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<Style> Styles { get; set; }


        public int BrandID { get; set; }
        public Brand Brand { get; set; }

    }
}

