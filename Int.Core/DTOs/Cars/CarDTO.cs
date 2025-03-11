﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.DTOs.Cars
{
    public class CarDTO
    {
        public string? Description { get; set; }
        //  public string? CModel { get; set; }

        public string Location { get; set; }
        public string PlateNumber { get; set; }
        public string? Color { get; set; }
        public string ? Brand { get; set; }
        //public string? BrandName { get; set; }
        //public string? ColorName { get; set; }
        public List<string> imageUrls { get; set; } = new List<string>();

    }
}
