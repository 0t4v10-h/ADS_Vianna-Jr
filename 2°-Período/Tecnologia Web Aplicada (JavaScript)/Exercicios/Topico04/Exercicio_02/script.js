var frutas = ["Banana", "Maça", "Pera", "Uva", "Melância"];

for (var i = 0; i < frutas.length; i++){
    console.log(frutas[i]);
    if (frutas[i] == "Pera"){
        break;
    }
}

// Usando forEach

frutas.forEach(function(fruta, i) {
    if (i <= 2){
        console.log(i, fruta);
    }
})
// ou
var imprimir = true;
frutas.forEach(fruta =>{
    if (imprimir){
        console.log(fruta);
    }
    if(fruta == "Pera"){
        imprimir == false;
    }
})