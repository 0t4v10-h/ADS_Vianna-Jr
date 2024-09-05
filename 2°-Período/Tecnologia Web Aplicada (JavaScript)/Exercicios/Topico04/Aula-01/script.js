// ARRAY e LOPS

var consoles = ["PS5", "Switch", "XBox", "SteamDeck"];

/*
for (var i = 0; i < consoles.length; i++){
    console.log(consoles[i]);
}
*/

// Usando forEach

consoles.forEach(function(videoGame){
    console.log(videoGame);
});

// ou

consoles.forEach(function(videoGame, indice){
    console.log(indice, videoGame);
});

//Transformando a função anonima em arrowfanction

consoles.forEach(videoGame => {
    console.log(videoGame);
});

// FILA e PILHA

// Fila -> Primeiro a chegar, primeiro a sair
var filaBanco = [];

filaBanco.push("Zé Ruela");
filaBanco.push("Zé Cú");
filaBanco.push("Zé Toba");
filaBanco.push("Zé Mané");

console.log("Ordem de atendimanto:");
console.log(filaBanco.shift());
console.log(filaBanco.shift());
console.log(filaBanco.shift());
console.log(filaBanco.shift());

// Pilha -> Ultimo a chegar, primeiro a sair
var pilhaPrato = [];

pilhaPrato.push("Zé Ruela");
pilhaPrato.push("Zé Cú");
pilhaPrato.push("Zé Toba");
pilhaPrato.push("Zé Mané");

console.log(pilhaPrato);
console.log("Ordem de lavagem dos pratos:");
console.log(pilhaPrato.pop());
console.log(pilhaPrato.pop());
console.log(pilhaPrato.pop());
console.log(pilhaPrato.pop());

