using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerRockMVC.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SneakerRockMVC.Controllers
{
    public class BrandController : Controller
    {
        // GET: /<controller>/
        private SneakerRockDbContext Context { get; }


        public BrandController(SneakerRockDbContext dbContext) : base()
        {
            Context = dbContext;

        }

        public IActionResult Index()
        {
            /*            var cheeses = from c in Context.Brands
                                      select c;

                        var isAuthorized = User.IsInRole(Constants.AdministratorsRole);

                        var currentUserId = UserManager.GetUserId(User);

                        if (!isAuthorized)
                        {
                            brands = brands.Where(char => c.UserID == currentUserID);
                        }

                        return View(cheeses.Include(cheeses => cheeses.Category).ToList());
                        */
            return View();
        }
    }
}
