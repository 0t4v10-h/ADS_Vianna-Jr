double salario;
Console.Write("Informe seu salario: ");
salario = Convert.ToDouble(Console.ReadLine());

double minimo;
Console.Write("Informe o salario minimo: ");
minimo = Convert.ToDouble(Console.ReadLine());

minimo = salario / minimo;
Console.WriteLine("Voce ganha {0:N2} salarios minimos.", minimo);
