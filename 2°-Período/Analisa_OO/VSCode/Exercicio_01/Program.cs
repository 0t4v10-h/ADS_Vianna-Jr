using Exercicio_01.models;

var a1 = new Aluno
{
    Matricula = 123,
    Nome = "Zé Cú",
    Email = "Zecu@.com"
};

var a2 = new Aluno
{
    Matricula = 456,
    Nome = "Zé Ruela",
    Email = "ZeRuela@.com"
};

var a3 = new Aluno
{
    Matricula = 789,
    Nome = "Zé bunda",
    Email = "ZeBunda@.com"
};

var prof = new Professor {Nome = "Zezão", Matricula = 000};

var turma = new Turma();
turma.Periodo = 2;
turma.Professor = prof;
turma.Matricular(a1);
turma.Matricular(a2);
turma.Matricular(a3);

for(int i = 0; i < turma.Alunos.Length; i++)
{
    Console.Write(turma.Alunos[i].Nome );
    Console.WriteLine();
    Console.Write(turma.Alunos[i].Matricula );
    Console.WriteLine();
    Console.WriteLine(turma.Alunos[i].Email );
    Console.WriteLine();


}