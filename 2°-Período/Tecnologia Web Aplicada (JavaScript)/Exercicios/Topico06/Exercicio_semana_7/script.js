let body = document.body;

let aumentar = document.getElementById("aumentarBtn");

aumentar.addEventListener("click", () =>{

    if(body.classList.contains("texto-pequeno")){
        body.classList.remove("texto-pequeno");
        body.classList.add("texto-regular");
    }else if(body.classList.contains("texto-pequeno")){
        body.classList.remove("texto-pequeno");
        body.classList.add("texto-regular");
    }
});


let diminuir = document.getElementById("diminuirBtn");

diminuir.addEventListener("click", () =>{
    
    if(body.classList.contains("texto-grande")){
        body.classList.remove("texto-grande");
        body.classList.add("texto-regular");
    }if(body.classList.contains("texto-regular")){
        body.classList.remove("texto-regular");
        body.classList.add("texto-pequeno");
    }
});
