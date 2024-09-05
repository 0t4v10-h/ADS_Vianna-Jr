/* Elaborar um programa que calcule e apresente o volume de uma 
caixa retangular, por meio da fórmula: 
volume = comprimento*largura*altura */




double comprimento, largura, altura;
Console.Write("Informe o comprimento do seu retangulo: ");
comprimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a largura do seu retangulo: ");
largura = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a altura do seu retangulo: ");
altura = Convert.ToDouble(Console.ReadLine());

double volume;

volume = comprimento * largura * altura;

Console.WriteLine("O volume do seu retangulo e: {0}", volume);
