using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}