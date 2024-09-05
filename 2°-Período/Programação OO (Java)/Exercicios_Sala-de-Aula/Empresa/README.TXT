Uma empresa possui varios funcionarios.
A empresa deseja calcular o valor recebido por todos os funcionarios

SalarioLiq = Salario Base - 13% inss + 10% se for gerente
    -3% se usar vale transporte + 50 por filho, ate 3 filhos
    se for vendedor recebe 2% das vendas realizadas.
    
Ao final mostre o funcionario com o maior salario da empresa.


1° passo - identificar as classes
Funcionario 
Empresa
Main

2° passo - atributos
Funcionario - salario, nome, funcao, noturno, filhos,valeTrans, totalVendas
Empresa - nome, listaFuncionarios

3° passo - responsabilidade
Funcionario - salario liquido
Empresa - FuncionarioMaiorSalario, somaSalarios