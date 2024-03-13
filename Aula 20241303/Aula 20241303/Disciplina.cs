using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20241303
{
    internal class Disciplina
    {
        private string codigo { get; set; }
        private string nome { get; set; }
        private Professor professor { get; set;}
        private List<string> preRequisitos { get; set; }


        public Disciplina(string codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public void addPreRequisito(Disciplina d)
        {
            preRequisitos.Add(d.codigo);
        }
    }
}
