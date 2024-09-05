// Importando a classe Pokemon do módulo Pokemon.js
import {Pokemon} from './pokemon.js';

// Elementos HTML para exibição do Pokémon e navegação
const numeroElemento = document.getElementById('num');
const nomeElemento = document.getElementById('name');
const tiposElemento = document.getElementById('types');
const imagemElemento = document.getElementById('sprite');
const botaoAnterior = document.getElementById('anterior');
const botaoProximo = document.getElementById('proximo');
const erroElemento = document.getElementById('erro');
const carregandoElemento = document.getElementById('loading');
const conteudoElemento = document.getElementById('conteudo');
const formularioPoke = document.getElementById('pokeForm');
const entradaPokemon = document.getElementById('pokemon');

// Elementos HTML para navegação no menu
const botaoExplorar = document.getElementById('explorar');
const botaoMidia = document.getElementById('midia');
const botaoSobre = document.getElementById('sobre');
const botaoVoltarInicio = document.getElementById('voltarInicio');

// Seções da página
const secaoPokedex = document.getElementById('pokedex-section');
const secaoExplorar = document.getElementById('explorar-section');
const secaoMidia = document.getElementById('midia-section');
const secaoSobre = document.getElementById('sobre-section');

// Inicialização do contador de Pokémon
let contador = 1;
botaoAnterior.style.display = "none";

// Função assíncrona para obter dados do Pokémon a partir da API
async function obterPokedex(id) {
    let resultado;
    try {
        const resposta = await fetch(`https://pokeapi.co/api/v2/pokemon/${id}`);
        const conteudo = await resposta.json();
        resultado = new Pokemon(
            conteudo.name,
            conteudo.id,
            conteudo.types,
            conteudo.sprites.other.home.front_default
        );
    } catch (e) {
        console.log(e);
        resultado = { erro: "Pokemon não encontrado" };
    }
    return resultado;
}

// Função para mostrar os dados do Pokémon na página
function mostrarPokemon(pokemon) {
    if (pokemon.erro) {
        erroElemento.innerText = pokemon.erro;
        erroElemento.style.display = "block";
        conteudoElemento.style.display = "none";
    } else {
        erroElemento.style.display = "none";
        conteudoElemento.style.display = "grid";
        numeroElemento.innerText = `N°: ${pokemon.numero}`;
        nomeElemento.innerText = pokemon.nome;
        tiposElemento.innerHTML = '';
        pokemon.tipos.forEach(tipo => {
            const item = document.createElement('li');
            item.innerText = tipo.type.name;
            tiposElemento.appendChild(item);
        });
        imagemElemento.src = pokemon.sprite;

        // Exibir o botão "Anterior" apenas se o número do Pokémon for maior que 1
        botaoAnterior.style.display = pokemon.numero > 1 ? "inline-block" : "none";
    }
}

// Função assíncrona para buscar e mostrar o Pokémon baseado no ID
async function buscarPokemon(id) {
    carregandoElemento.style.display = "block";
    conteudoElemento.style.display = "none";
    const pokemon = await obterPokedex(id);
    mostrarPokemon(pokemon);
    carregandoElemento.style.display = "none";
    // Ocultar o botão de próximo se estiver no último Pokémon
    if (contador >= 1025) {
        botaoProximo.style.display = "none";
    } else {
        botaoProximo.style.display = "inline-block";
    }
}

// Evento de clique para o botão "Próximo"
botaoProximo.addEventListener('click', () => {
    contador++;
    buscarPokemon(contador);
});

// Evento de clique para o botão "Anterior"
botaoAnterior.addEventListener('click', () => {
    contador--;
    if (contador <= 1) {
        contador = 1;
    }
    buscarPokemon(contador);
    // Exibir o botão de próximo se não estiver no último Pokémon
    if (contador < 1025) {
        botaoProximo.style.display = "inline-block";
    }
});

// Evento de submissão do formulário de busca de Pokémon
formularioPoke.addEventListener('submit', async (e) => {
    e.preventDefault();
    const nomePokemon = entradaPokemon.value.toLowerCase().trim();
    if (nomePokemon) {
        conteudoElemento.style.display = "none";
        carregandoElemento.style.display = "block";
        const pokemon = await obterPokedex(nomePokemon);
        if (!pokemon.erro) {
            contador = pokemon.numero;
            mostrarPokemon(pokemon);
        } else {
            erroElemento.innerText = pokemon.erro;
            erroElemento.style.display = "block";
            conteudoElemento.style.display = "none";
        }
        carregandoElemento.style.display = "none";
    }
});

// Função para esconder todas as seções
function esconderTodasSecoes() {
    secaoPokedex.classList.add('hidden');
    secaoExplorar.classList.add('hidden');
    secaoMidia.classList.add('hidden');
    secaoSobre.classList.add('hidden');
}

// Função para mostrar a seção da Pokédex
function mostrarSecaoPokedex() {
    esconderTodasSecoes();
    secaoPokedex.classList.remove('hidden');
    atualizarMenu('pokedex');
}

// Função para atualizar o menu de navegação com base na seção ativa
function atualizarMenu(secaoAtiva) {
    botaoExplorar.classList.remove('hidden');
    botaoMidia.classList.remove('hidden');
    botaoSobre.classList.remove('hidden');
    botaoVoltarInicio.classList.add('hidden');

    if (secaoAtiva === 'explorar') {
        botaoExplorar.classList.add('hidden');
        botaoVoltarInicio.classList.remove('hidden');
    } else if (secaoAtiva === 'midia') {
        botaoMidia.classList.add('hidden');
        botaoVoltarInicio.classList.remove('hidden');
    } else if (secaoAtiva === 'sobre') {
        botaoSobre.classList.add('hidden');
        botaoVoltarInicio.classList.remove('hidden');
    }
}

// Eventos de clique para os botões do menu de navegação
botaoExplorar.addEventListener('click', () => {
    esconderTodasSecoes();
    secaoExplorar.classList.remove('hidden');
    atualizarMenu('explorar');
});

botaoMidia.addEventListener('click', () => {
    esconderTodasSecoes();
    secaoMidia.classList.remove('hidden');
    atualizarMenu('midia');
});

botaoSobre.addEventListener('click', () => {
    esconderTodasSecoes();
    secaoSobre.classList.remove('hidden');
    atualizarMenu('sobre');
});

botaoVoltarInicio.addEventListener('click', mostrarSecaoPokedex);

// Chama a função para carregar o primeiro Pokémon ao iniciar
buscarPokemon(contador);
