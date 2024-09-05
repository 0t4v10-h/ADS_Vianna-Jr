double temp;
Console.Write("Informe a temperatura em graus Celsius: ");
temp = Convert.ToDouble(Console.ReadLine());

double resultado;
resultado = (9.0 * temp + 160.0)/5.0;
Console.WriteLine("A temperatura em F° é {0}", resultado);