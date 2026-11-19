using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Today;
        public int IdEquipaA { get; set; }
        public int IdEquipaB { get; set; }
        // null = partida ainda por jogar
        public int? ResultadoA { get; set; }
        public int? ResultadoB { get; set; }
    }
}