let imagens = [
    "img/6.png",
    "img/64.png",
    "img/130.png",
    "img/144.png",
    "img/150.png",
    "img/249.png",
    "img/373.png",
    "img/392.png",
    "img/483.png"];

let nomes = [
    "Charizard",
    "Kadabra",
    "Gyarados",
    "Articuno",
    "Mewtwo",
    "Lugia",
    "Salamence",
    "Infernape",
    "Dialga"]; 

let atual = 0;

let grupo = document.querySelector("div");
//grupo.innerHTML += `<div id="nome"></div>`;

let nome = document.createElement("div");    // Criando uma nova "div"
grupo.appendChild(nome);
nome.innerText = nomes[atual];

let quadro = document.querySelector("img");
quadro.setAttribute("src", imagens[atual]);

/*let nome = document.getElementById("nome");
nome.innerText = nomes[atual];*/

let proximo = document.getElementById("proximo");

proximo.addEventListener("click", event =>{
    event.preventDefault();

    if(atual == imagens.length){
        atual = 0;        
    }
    nome.innerText = nomes[atual];
    quadro.setAttribute("src", imagens[atual++]);
});

let anterior = document.getElementById("anterior");
anterior.addEventListener("click", event =>{
    event.preventDefault();

    if(atual <= 0){
        atual = imagens.length;
    }
    nome.innerText = nomes[atual - 1];
    quadro.setAttribute("src", imagens[--atual])

});
