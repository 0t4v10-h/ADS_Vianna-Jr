function marianaConta(conta){
    var letra = "";

    for (var i = 1; i <= conta; i++) {

        letra += `Mariana conta ${i} \n`; 
        letra += `Mariana conta ${i}:`;
        for(var j = 1; j <= i; j++){
            letra += `é ${j},`
        }
        letra += `é!\n`;
        letra += `Ana, viva a Mariana, viva a Mariana \n \n`;

    }

console.log(letra);
}

marianaConta(10);
