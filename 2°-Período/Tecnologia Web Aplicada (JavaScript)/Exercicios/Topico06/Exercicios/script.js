
// EXERCICIOS 
// Respostas 

let var1 = document.getElementsByClassName("small-heading");
    
let var2 = document.querySelectorAll(".small-heading"); 

let aux1 = Array.from(var1);
aux1.forEach(element => {
    console.log(element);
}); // Não implementa o forEach, para isso precisa criar um Array e implementar o elemento no array.

var2.forEach(element => {
    console.log(element);
}); // Melhor e de mais uso, dar preferencia a ele.

// Pegando a primeira imagem e pode acessar seus atributos
let imagem = document.querySelector("img");
console.log(imagem.attributes["height"]);

// Mudando os atributos, exemplo mudando a imagem
imagem.setAttribute("src", "https://sm.ign.com/ign_br/screenshot/default/blob_hbbk.jpg");

// Trocando o background para azul e a cor da fonte para amarelo
let color = document.querySelector("body");
color.setAttribute("style", "background-color: blue; color: yellow");

// Colocando uma mensagem ao clicar na imagem
let imagens = document.querySelectorAll("img");
imagens.forEach(imagens =>{
    imagens.addEventListener("click", ()=>{
        alert("Clicou!");
    });
});


