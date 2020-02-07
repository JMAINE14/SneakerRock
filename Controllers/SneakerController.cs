using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerRock.ViewModels;
using SneakerRockMVC.Data;
using SneakerRockMVC.Models;

namespace SneakerRock.Controllers
{
    public class SneakerController : Controller
    {
        private readonly SneakerRockDbContext context;

       // public object Context { get; private set; }
       // public object SneakerData { get; private set; }

        public SneakerController(SneakerRockDbContext dbContext) : base()
        {
            context = dbContext;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //List<Sneaker> sneakers = context.Sneakers.ToList();

            //    return View(sneakers);
            return View();
        }

        public IActionResult Create()
        {
            AddSneakerViewModel addSneakerViewModel =
                new AddSneakerViewModel();

            return View(addSneakerViewModel);
        }

        [HttpPost]
        public IActionResult Create(AddSneakerViewModel vm)
        {
            Brand br = new Brand
            {
                Name = vm.Brand
            };
            context.Brands.Add(br);

            BrandName bName = new BrandName
            {
                Name = vm.BrandName,
                Brand = br
            };
            context.BrandNames.Add(bName);

            Style stl = new Style
            {
                Name = vm.Style,
                BrandName = bName
            };
            context.Styles.Add(stl);

            ColorWay cWay = new ColorWay
            {
                Name = vm.Colorway,
                Style = stl
            };
            context.Colorways.Add(cWay);


            return View();
        }
    }
}
