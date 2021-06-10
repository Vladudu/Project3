using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Comanda
    {
        public Guid ID { get; set; }
        public string Continut { get; set; }

        public string AdresaPentruLivrare { get; set; }
        public DateTime DataComenzii { get; set; }
        public int TotalPret { get; set; }


    }
}
