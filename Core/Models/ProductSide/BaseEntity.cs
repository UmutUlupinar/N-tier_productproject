﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.ProductSide
{
    public class BaseEntity
    {    
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
