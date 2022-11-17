using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Models.ViewModel
{
    public class FormBeerViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Style { get; set; }
        [Display(Name = "Brand")]
        public Guid? BrandId { get; set; }
        [Display(Name = "Other Brand")]
        public string OtherBrand { get; set; }
    }
}
