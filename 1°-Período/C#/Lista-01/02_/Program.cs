double altura;
Console.Write("Informe sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());

double massa;
Console.Write("Informe seu peso: ");
massa = Convert.ToDouble(Console.ReadLine());

double imc;
imc = massa / Math.Pow(altura , 2);

Console.WriteLine("Seu IMC e: {0:N}", imc);
