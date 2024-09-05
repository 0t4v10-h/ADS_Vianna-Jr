/* Defina uma classe para representar as informações de um 
cartão de crédito. No método principal (Main) da classe 
Program, instancie dois objetos do tipo da classe criada, 
atribua valores a cada atributo dos objetos e imprima todos os 
atributos do segundo objeto instanciado. */

class Program
{
    static void Main(string[] args)
    {
        Cartao cartao1 = new Cartao();
        cartao1.Nome = "Otavio Henrique";
        cartao1.Numero = 123;

        Cartao cartao2 = new Cartao();
        cartao2.Nome = "Maria Fernanda";
        cartao2.Numero = 321;

        Console.Write("Nome no cartão: {0} \nNúmero do cartão: {1}", cartao2.Nome, cartao2.Numero);
    }
}