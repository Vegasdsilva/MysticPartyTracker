using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Character
    {
        public Character(string nome, string classe, string raca, int nivel)
        {
            Nome = nome;
            Classe = classe;
            Raca = raca;
            Nivel = nivel;
        }

        public string Nome { get; set; }
        public string Classe { get; set; }
        public string Raca { get; set; }
        public int Nivel { get; set; }
    }
}
