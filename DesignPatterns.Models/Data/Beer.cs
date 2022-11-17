using System;
using System.Collections.Generic;

namespace DesignPatterns.Models.Data
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public Guid? BranId { get; set; }

        public virtual Brand Bran { get; set; }
    }
}
