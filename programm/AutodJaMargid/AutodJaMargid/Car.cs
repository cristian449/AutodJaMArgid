using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutodJaMargid
{
    public class Car
    {
        public int CarID { get; set; }

        public string? CarName { get; set; }

        public int BrandID { get; set; }

        public virtual Brand Brand { get; set; } = null!;

    }
}
