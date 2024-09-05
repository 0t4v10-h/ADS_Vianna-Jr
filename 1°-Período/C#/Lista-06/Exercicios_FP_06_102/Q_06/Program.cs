/*  Refaça o exercício (3) criando uma função que 
receba o vetor com a idade dos alunos e retorne a 
quantidade de alunos com idade superior a média.  */


class Program
{
    static double calculaAlunos(double[] id, double media)
    {      
        int cont = 0; 
        for (int i = 0 ; i < id.Length; i++)
        {
           if (id[i] > media) cont++;       
        }
        
        return cont;
    }

    static void Main(string[] args)
    {
        double [] idade;
        idade = new double[10];
        double media = 0.0, soma = 0.0; 
        double recebe;

        for(int i = 0;  i < idade.Length; i++)
        {
            Console.Write("Informe a idade {0} de {1}: ", i + 1, idade.Length);
            idade[i] = Convert.ToDouble(Console.ReadLine());  
            soma += idade[i];    
        }
        
        media = soma / 10;  
        Console.WriteLine("Média das idades: {0}", media);
        recebe = calculaAlunos(idade, media);

        Console.Write("Idades acima da média: {0}", recebe);
    }
}