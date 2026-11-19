using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Models
{
    // Linha de um jogador nas estatisticas (calculada, não é guardada)
    public class PlayerRow
    {
        public int Position { get; set; }
        public string Nickname { get; set; } = "";
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Team { get; set; } = "";
        public string Tournament { get; set; } = "";
        public int ScoreCount { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
    }
}