/* Faça um algoritmo que leia a idade de 10 alunos,
e que calcule o número de alunos com idade superior a média.  */

class Program
{
    static void Main(string[] args)
    {
        double [] idade;
        idade = new double[10];
        double media = 0.0, soma = 0.0; 

        for(int i = 0;  i < idade.Length; i++)
        {
            Console.Write("Informe a idade {0} de {1}: ", i + 1, idade.Length);
            idade[i] = Convert.ToDouble(Console.ReadLine());  
            soma += idade[i];    
        }
        
        media = soma / 10;  
        
        int cont = 0; 
        for (int j = 0 ; j < idade.Length; j++)
        {
           if (idade[j] > media) cont++;       
        }
        Console.Write("Media: {0} \nIdades acima da média: {1}", media, cont);
    }
}