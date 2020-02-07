using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerRock.ViewModels
{
    public class AddSneakerViewModel
    {
        private object p;

        public AddSneakerViewModel()
        {
        }

        public AddSneakerViewModel(object p)
        {
            this.p = p;
        }

        [Required]
        [Display(Name = "Enter a brand:")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Enter a brand line:")]
        public string BrandName { get; set; }

        [Required]
        [Display(Name = "Enter a style:")]
        public string Style { get; set; }

        [Required]
        [Display(Name = "Enter a colorway:")]
        public string Colorway { get; set; }



    }
}
