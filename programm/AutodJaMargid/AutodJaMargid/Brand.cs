using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AutodJaMargid
{
    public class Brand
    {
        public int BrandID { get; set; }

        public string? BrandName { get; set; }

        public virtual ObservableCollectionListSource<Car> Cars { get; } = new();

    }
}
