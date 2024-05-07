using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Character
    {
        public string Nome { get; set; } = string.Empty;
        public string Classe { get; set; } = string.Empty;
        public string Raca { get; set; } = string.Empty;
        public int Nivel { get; set; }
    }
}
