using System;
using System.Collections.Generic;

namespace mvcCrud.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Date { get; set; }
        public string? Code { get; set; }
    }
}
