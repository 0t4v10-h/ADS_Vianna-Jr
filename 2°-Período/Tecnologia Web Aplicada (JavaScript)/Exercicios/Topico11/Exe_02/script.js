setTimeout(function() {
    console.log('Time 1');
});
  
setTimeout(function() {
  console.log('Time 2');
}, 100);
  
console.log('Log 1');
  
setTimeout(function() {
  console.log('Time 3');
}, 50);
  
console.log('Log 2');

  /*  */
  
const promessa = new Promise(function(resolve, reject){
  let condicao;
  let endereco;

  setTimeout(() =>{
    condicao = true;
    endereco = "Rua A";
    if(condicao){
      resolve(endereco);
    } else{
      reject(Error(' Não foi possivel carregar endereço!'));
    }
  }, 2000);
});

promessa.then((resolve) =>{

  document.body.innerText = resolve;
    return "Juiz de Fora";
}).catch(reject =>{
  document.body.innerText = reject;
}).finally(() =>{
  document.body.innerHTML += `<br> Processamento finalizado!`;
});

  

document.body.innerText = "Carregando...";

/*
}).then((resolve) =>{
  document.body.innerHTML += `<br> ${resolve}`;
    return "MG";

}).then((resolve) =>{
  document.body.innerHTML += `<br> ${resolve}`;
});
*/