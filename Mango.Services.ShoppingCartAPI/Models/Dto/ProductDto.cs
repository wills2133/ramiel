﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}