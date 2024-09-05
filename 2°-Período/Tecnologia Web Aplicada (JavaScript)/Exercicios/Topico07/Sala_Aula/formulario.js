let form = document.forms[0];
let erros = document.createElement("div");
document.body.appendChild(erros);

form.addEventListener("submit", event =>{

    event.preventDefault();
    let texto = form.elements["texto"];
    let numero = form.elements["numero"];
    erros.innerHTML = "";

    let countErros = 0;

    if(texto.value == ""){
        countErros++;
        erros.innerHTML += "<p> O texto não pode ser vazio! </p>";
    }

    if(numero.value < 100){
        countErros++;
        erros.innerHTML += "<p> O numero deve ser maior que 100!</p>";
    }

    if(countErros == 0){
        form.submit();
    }
});