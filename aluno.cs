using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO_aula_3
{
    internal class Aluno
    {
        string nome;
        short turma;
        double mediaNotas;

        public Aluno(string nome, short turma)
        {
            this.nome = nome;
            this.turma = turma;
        }

        //public string getNome() { return nome; }

        //public void setNome(string nome){ this.nome = nome; }

        public string Nome
        {
            get {return nome; }
            set { nome = value; }
        }

        public int Turma { get; set; }
    }
}
