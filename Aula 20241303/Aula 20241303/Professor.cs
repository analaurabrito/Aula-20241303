using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20241303
{
    internal class Professor
    {
        private string ID { get; set; }
        private string nome { get; set; }

        public Professor(string iD, string nome)
        {
            ID = iD;
            this.nome = nome;
        }
    }
}
