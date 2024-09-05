double preco;
Console.Write("Informe o preco do produto: ");
preco = Convert.ToDouble(Console.ReadLine());

double desconto;
desconto = preco - (preco * 25.0) / 100.0;

Console.WriteLine("O valor a pagar é: {0:N2}", desconto);