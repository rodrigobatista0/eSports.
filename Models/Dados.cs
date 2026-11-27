using eSports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eSports.Models
{
    [XmlRoot("Campeonatos")]
    public class Dados
    {
        [XmlElement("Campeonato")]
        public List<Campeonato> Campeonatos { get; set; } = new List<Campeonato>();
    }
}