double ladoA; double baseT; double ladoB;
Console.Write("Informe o lado A do triangulo: ");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a base do triangulo: ");
baseT = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o lado B do triangulo: ");
ladoB = Convert.ToDouble(Console.ReadLine());

double resultado;
resultado = ladoA + baseT + ladoB;
Console.WriteLine("O perimetro do seu triangulo é {0}", resultado);

double altura;
Console.Write("Informe a altura do seu triangulo: ");
altura = Convert.ToDouble(Console.ReadLine());

double area;
area = baseT * altura / 2.0;
Console.WriteLine("A area do seu triangulo é {0}", area);
