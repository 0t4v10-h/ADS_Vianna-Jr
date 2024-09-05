function elefanteIncomoda(conta) {
    var letra = `1 elefante incomoda muita gente! \n \n`;

    for(var i = 2; i <= conta; i++){

        if(i % 2 == 1){
            letra += `${i} elefantes incomodam muita gente! \n \n`;
        }else{
            letra += `${i} elefantes `;

            for(var j = 0; j < i; j++){
                letra += `incomodam `;
            }

            letra += `muito mais \n \n`;
        }
    }
    console.log(letra);

    var letra2 = "";

    for(var k = conta; k > 1; k--){

        if(k % 2 == 0){
            letra2 += `${k} elefantes incomodam muita gente! \n \n`;
        }else{
            letra2 += `${k} elefantes `;

            for(var l = 0; l < k; l++){
                letra2 += `incomodam `;
            }
            letra2 += `muito menos \n \n`;
        }     
    }
    letra2 += `1 elefante incomoda muito menos`;

    console.log(letra2);
}

elefanteIncomoda(10);