/*  Desenvolver um algoritmo para ler o número 
do dia da semana e imprimir o seu 
respectivo nome por extenso. Considerar o 
número 1 como domingo, 2 para segunda 
etc. Caso o dia da semana não exista 
(menor do que 1 ou maior do que 7), exibir a 
mensagem “Dia da semana inválido". */

class Program 
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        int numero;
        Console.Write("Informe o dia da semana em numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == 1)
             Console.Write("Dia de bad! Domingo.");
        
        else if (numero == 2)
             Console.Write("Infelismente hoje é segunda.");
        
        else if (numero == 3)    
             Console.Write("Rlx começo da semana ainda, terça.");
        
        else if (numero == 4)
             Console.Write("Meio da semana meu mano, quarta.");
        
        else if (numero == 5)
             Console.Write("Quinta, ta quase.");
        
        else if (numero == 6)        
             Console.Write("SEXTOOOOOOU! BEBE ");
       
        else if (numero == 7)          
             Console.Write("Sabado, hoje é onde?");

        else        
             Console.Write("Dia da semana inválido");        
    }
}