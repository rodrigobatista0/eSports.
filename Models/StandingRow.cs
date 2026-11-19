using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Models
{
    // Linha da classificação (calculada, não é guardada)
    public class StandingRow
    {
        public int Position { get; set; }
        public string Team { get; set; } = "";
        public int Played { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Points { get; set; }
        public double Average { get; set; }
    }
}