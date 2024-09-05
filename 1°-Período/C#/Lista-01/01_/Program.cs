double primeiro;
double segundo;

Console.Write("Informe um numero: ");
primeiro = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe outro numero: ");
segundo = Convert.ToDouble(Console.ReadLine());

double adicao;
double subtracao;
double divisao;
double multiplicacao;

adicao = primeiro + segundo;
subtracao = primeiro - segundo;
divisao = primeiro / segundo;
multiplicacao = primeiro * segundo;

Console.Write("Seus numeros nas operacoes matematicas sao; Soma: {0}, Subtracao: {1}, Divisao: {2}, Multiplicacao: {3}.", adicao, subtracao, divisao, multiplicacao);
