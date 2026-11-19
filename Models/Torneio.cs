using eSports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Models
{
    public class Torneio
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Jogo { get; set; } = "";
        public List<Equipa> Equipas { get; set; } = new List<Equipa>();
        public List<Partida> Partidas { get; set; } = new List<Partida>();
    }
}