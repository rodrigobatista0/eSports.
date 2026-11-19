using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Models
{
    public class Campeonato
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public int Ano { get; set; }
        public List<Torneio> Torneios { get; set; } = new List<Torneio>();
    }
}