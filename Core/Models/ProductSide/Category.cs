using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.ProductSide
{
    public class Category: BaseEntity
    {
       
        public virtual ICollection<Product> Products { get; set; }

    }

    
}
