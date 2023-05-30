using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;

namespace Rocky.Models.ViewModels
{
    public class HomeVm
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set;}
    }
}
