using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class Contracte
    {
        public Guid ID { get; set; }

        public string Nume { get; set; }

        public string Contract { get; set; }

        public string DetaliiContract { get; set; }

        public string DurataContract { get; set; }
    }
}
