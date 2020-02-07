using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerRockMVC.Models
{
    public class Collection
    {
        public int SneakerID { get; set; }
        public int ShoeSize { get; set; }
        public DateTime DatePurchased { get; set; }
        public int ID { get; set; }
    }
}
