// Seletor de ID ---- melhor e mais utilizado
let citacao = document.getElementById("quote-by-author");
citacao.innerText = "NOVO TEXTO";
console.log(citacao);

// Seletor de classe ---- não é muito usado, porem tambem funciona
let cabecalhosPequenos = document.getElementsByClassName("small-heading");
console.log(cabecalhosPequenos);

//Seletor de tag ---- busca apenas dentro do UL
let listas = document.getElementsByTagName("ul");
console.log(listas);


/* 
Outros modelos de seletores

const animais = document.querySelector('.animais');
const contato = document.querySelector('#contato');
const ultimoItem = document.querySelector('.animais-lista li:last-child');
const linkCSS = document.querySelector('[href^="https://"]');
const primeiroUl = document.querySelector('ul');

// Busca dentro do Ul apenas
const navItem = primeiroUl.querySelector('li');
*/


// document.querySelector -> sempre retornara o primeiro elemento que corresponde ao seletor
let cita = document.querySelector("quote-by-author"); // outro seletor de ID

// Pegar o primeiro elemento da classe
let cabecalhosPeq = document.querySelector(".small-heading"); 

let lis = document.querySelector("ul");

// All no final faz pegar todos os elementos
let cabecalhoPequeno = document.querySelectorAll(".small-heading"); 

//Todos os elementos <li> filhos de <ul>
let liFihoUl = document.querySelectorAll("ul > li");
console.log(liFihoUl); 

// CLASSLIST

let primeiro = document.querySelector("header > h1:first-child");

let segundo = document.querySelector("header > h2:first-of-type");

// adiciona uma classe a lista
primeiro.classList.add("small-heading");

// Remove a classe da lista
primeiro.classList.remove("small-heading"); 

// Adicionando a classe "bgBlack" no "body"
//let corpo = document.querySelector("body");
//corpo.classList.add("bgBlack");

document.body.classList.add("bgBlack"); // fazendo de uma forma mais direta que a anterior.

// Usado para add e remover uma classe a lista, se a classe estiver add ele remove ou vice-versa.
document.body.classList.toggle("bgBlack");

// Retorna "true" ou "false", true se a classe estiver no elemento e folse se nao tiver.
primeiro.classList.contains("bold");

// Usado para substituir uma classe de um elemento.
let artigo = document.querySelector("article");
primeiro.classList.replace("on", "off");

// Exibindo no console o paragrafo que clicar e adicionando a classe "off".
let paragrafos = document.querySelectorAll("p");
paragrafos.forEach(paragrafo => {
    paragrafo.addEventListener("click", (event) =>{
        console.log(event.target);                  // Pegando o paragrafo que clicar.
        event.target.classList.toggle("off");
    })
});

let links = document.querySelectorAll("a");

links.forEach(link => {
    link.addEventListener("click", event =>{
        event.preventDefault();                  // Previne do comportamento padrão.
        document.body.classList.add("bgBlack");
    })
})

// Exibe qual tecla o usuario pressionou
window.addEventListener("keydown", event =>{
    console.log(event);
})

// Ao apertar a tecla "m" a classe "bgBlack" é acionada.
window.addEventListener("keydown", event =>{
    console.log(event.key);
    if(event.key == "m"){
        document.body.classList.toggle("bgBlack");
    }
})

// Mudando o elemento de lugar
let imagem = document.querySelector("img");
let art = document.querySelector("article");
let rodape = document.querySelector("footer");

art.appendChild(imagem);  // Colocando a imagem no final do article.

art.insertBefore(imagem, rodape); // Colocando a imagem antes do ropade.

// Criando novo elemento.
let novaDiv = document.createElement("div");

art.appendChild(novaDiv);

novaDiv.innerText = "Nova Div"; // Mudando o texto do elemento.
novaDiv.className = "off";      // Adicionando a classe "off" no elemento.