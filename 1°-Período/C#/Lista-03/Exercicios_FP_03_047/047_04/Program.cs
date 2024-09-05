int numero;
Console.Write("Digite algum numero real: ");
numero = Convert.ToInt32(Console.ReadLine());

int antecessor;
antecessor = numero - 1;

int sucessor;
sucessor = numero +1;

Console.WriteLine("O antecessor do seu numero é {0} e o sucessor é {1}", antecessor, sucessor);
