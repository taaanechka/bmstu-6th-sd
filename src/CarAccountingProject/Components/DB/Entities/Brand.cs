using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManufactCountry { get; set; }
        public string Wheel { get; set; }
    }
}
