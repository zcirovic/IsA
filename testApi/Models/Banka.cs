using System;
using System.Collections.Generic;

namespace testApi.Models
{
    public partial class Banka
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Mesto { get; set; }
        public string Adresa { get; set; }
    }
}
