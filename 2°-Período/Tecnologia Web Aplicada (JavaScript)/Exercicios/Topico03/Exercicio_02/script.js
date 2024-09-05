var carro = {};
var pessoa = {};

carro.ano = 2020;
pessoa.nome = "Zé Ruela";

pessoa.imprimeNome = function(){
    console.log(this.nome);
}

imprimeNome();