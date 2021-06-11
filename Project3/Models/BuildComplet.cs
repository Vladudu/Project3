using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class BuildComplet
    {
        public Guid ID { get; set; }

        public string NumeClient { get; set; }

        public string Componente { get; set; }

        public string DataComenzii { get; set; }

        public int PretTotal { get; set; }
    }
}
