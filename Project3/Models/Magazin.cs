using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Magazin
    {
        public Guid ID { get; set; }
        public string Denumire { get; set; }
        public string Specificatii { get; set; }
        public string Status { get; set; }
        public int Pret { get; set; }

    }
}
