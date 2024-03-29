﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImgURL { get; set; } = string.Empty;

        public double Price { get; set; }

        public Category? Category { get; set; }

        public int CategoryId { get; set; }
    }
}
