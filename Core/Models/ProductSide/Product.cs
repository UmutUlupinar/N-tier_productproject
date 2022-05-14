using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.ProductSide
{
    public class Product: BaseEntity
    {
        
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
