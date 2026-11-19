using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Models
{
    public class Equipa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Pais { get; set; } = "";
        public List<Jogador> Jogadores { get; set; } = new List<Jogador>();
    }
}