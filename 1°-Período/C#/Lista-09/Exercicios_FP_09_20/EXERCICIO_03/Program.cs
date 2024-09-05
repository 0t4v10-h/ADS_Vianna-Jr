/* Considerando a classe do exercício (2) e a inicialização abaixo:
joao.altura <- 1.90; joao.peso <- 98;
maria.altura <- 1.50; maria.peso <- 55;
- Escreva uma instrução que atribua 1.78 à altura de joao;
- Escreva uma instrução que atribua 75 ao peso de maria.
- Escreva um conjunto de instruções para imprimir a média
das alturas e a média dos pesos de joao e maria. */

class Program
{
    static void Main(string[] args)
    {
    Peso_Altura joao = new Peso_Altura();

    joao.Altura = 1.78;
    joao.Peso = 98.0;

    Peso_Altura maria = new Peso_Altura();

    maria.Altura = 1.90;
    maria.Peso = 55.0;

    Peso_Altura media = new Peso_Altura();
    media.Altura = (joao.Altura + maria.Altura) / 2;
    media.Peso = (joao.Peso + maria.Peso) / 2;

    Console.Write("Media das alturas: {0:n2} \nMedia dos pesos: {1:n2}", media.Altura, media.Peso);
    }
}