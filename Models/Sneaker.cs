using System;
using System.Collections.Generic;

namespace SneakerRockMVC.Models
{
    public class Sneaker
    {
        public int ID { get; set; }
       
        public int ColorWayID { get; set; }
        public ColorWay ColorWay { get; set; }

        public DateTime DateReleased { get; set; }

    }

}