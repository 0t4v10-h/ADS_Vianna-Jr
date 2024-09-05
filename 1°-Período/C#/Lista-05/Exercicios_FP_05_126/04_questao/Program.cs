/* Escreva um algoritmo que leia a matrícula de um aluno e suas três notas. 
Calcule a média ponderada do aluno, considerando que o peso para a maior 
nota seja 4 e para as duas restantes, 3. Mostre ao final a média calculada e 
uma mensagem "APROVADO" se a média for maior ou igual a 5 e 
"REPROVADO" se a média for menor que 5. Repita a operação até que o 
código lido seja negativo. */

class Program
{
    static double calcularMedia(double nota1, double nota2, double nota3)
    {                    
        double media = 0.0;
            
        if (nota1 > nota2 && nota1 > nota3)
        {
            nota1 *= 4.0;
            nota2 *= 3.0;
            nota3 *= 3.0;
        }
        else if (nota2 > nota1 && nota2 > nota3)
        {
            nota2 *= 4.0;
            nota1 *= 3.0;
            nota3 *= 3.0;
        }
        else 
        {
            nota3 *= 4.0;
            nota1 *= 3.0;
            nota2 *= 3.0;
        }                                                      
         
        media = (nota1 + nota2 + nota3) / 10.0;
       
        if (media >= 5.0)
            {
                Console.WriteLine("Media = {0} \nAPROVADO.", media);
            }
            else 
            {
                Console.WriteLine("Media = {0} \nREPROVADO.", media);
            }  
             
        return media;

    }
    static void Main(string [] args)
    {   
        while (true)
        {                         
            double matri, not1, not2, not3, recebe;

            Console.Write("Informe a sua matrícula (negativo para sair): ");
            matri = Convert.ToDouble(Console.ReadLine());

            if (matri < 0)
            {
                Console.Write("Programa encerrado.");
                break;
            }

            Console.Write("Qual a sua primeira nota: ");
            not1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual a sua segunda nota: ");
            not2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual a sua terceira nota: ");
            not3 = Convert.ToDouble(Console.ReadLine());        

            recebe = calcularMedia (not1, not2, not3);
        }                  
    }
}