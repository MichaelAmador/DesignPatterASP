using System;
using System.Collections.Generic;

namespace DesignPatterns.Models.Data
{
    public partial class Brand
    {
        public Brand()
        {
            Beer = new HashSet<Beer>();
        }

        public Guid BrandId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Beer> Beer { get; set; }
    }
}
