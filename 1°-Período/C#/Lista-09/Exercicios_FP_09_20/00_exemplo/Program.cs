int idade;
idade = 20;

Aluno obj1 = new Aluno();

obj1.Matricula = 123;
obj1.Nome = "Maria";
obj1.Endereco.logradouro = "Rua Tal";
obj1.Endereco.numero = 49;


Aluno obj2 = new Aluno();

obj2.Matricula = 456;
obj2.Nome = "João";
obj2.Endereco.logradouro = "Rua de cima";
obj2.Endereco.numero = 73;

Aluno obj3 = new Aluno();

obj3.Matricula = 789;
obj3.Nome = "Ana";
obj3.Endereco.logradouro = "Rua sem saida";
obj3.Endereco.numero = 3;

Console.WriteLine("Olá {0}, a sua matrícula é {1}!", obj1.Nome, obj1.Matricula);
Console.WriteLine("Você mora na {0}, número da sua casa é {1}.", obj1.Endereco.logradouro, obj1.Endereco.numero);
Console.WriteLine("Olá {0}, a sua matrícula é {1}!", obj2.Nome, obj2.Matricula);
Console.WriteLine("Você mora na {0}, número da sua casa é {1}.", obj2.Endereco.logradouro, obj2.Endereco.numero);
Console.WriteLine("Olá {0}, a sua matrícula é {1}!", obj3.Nome, obj3.Matricula);
Console.WriteLine("Você mora na {0}, número da sua casa é {1}.", obj3.Endereco.logradouro, obj3.Endereco.numero);