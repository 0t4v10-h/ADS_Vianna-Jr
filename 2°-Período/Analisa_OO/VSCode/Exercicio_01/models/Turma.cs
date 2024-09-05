using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_01.models
{
    public class Turma
    {
        public int Periodo { get; set; }
        public Professor? Professor { get; set; }
        public void Matricular(Aluno obj)
        {
            if(alunos.Count > 100)
                throw new Exception("O número máximo de alunos foi excedido.");

            alunos.Add(obj);
        }

        public Aluno[] Alunos
        {
            get => alunos.ToArray();
        }
        private  List<Aluno> alunos = new List<Aluno>();
    }
}