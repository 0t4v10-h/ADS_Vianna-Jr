// Exercicio 1
var nome = "Otavio";
nome = 1234;
console.log(nome);

var pontos = 10;
var jogador = "Zé";
//var resultado = jogador + " " + "fez " + pontos + " " + "\"pontos\"";

var resultado = `${jogador} fez:
${pontos} "pontos".`;

console.log(resultado);

var nome = "Zé";
var numero = 7;
var idade = 70;
var str = `Meu nome é ${nome} e minha idade é ${idade}`;
var sobrenome = "Mané";
var nomeCompleto = nome + " " + sobrenome;
var ingles = "It's study time";

console.log(typeof(nome));

// Exercicio 2

var nome1 = "Otavio";
var idade1 = 24;
var nome2 = "Jonas";
var idade2 = 27;

if(idade1 > idade2){
    console.log("É maior");
} else if(idade1 == idade2){
    console.log("É igual");
} else{
    console.log("É menor");
}  

// Exercicio 3

var possuiCarro = true; 
var possuiCasa = true;
var darCredito;

if(possuiCarro == true && possuiCasa == true){
    darCredito = true;
} else{
    darCredito = false;
}
console.log(darCredito);