// Ao clicar no botão + deve ser adicionado um novo grupo para adicionar um telefone

let botao = document.querySelector(".btn-add");

botao.addEventListener("click", event =>{
    event.preventDefault();

    let phoneGroup = document.querySelector(".phoneGroup");
    let novoTel = phoneGroup.cloneNode(true);
    phoneGroup.parentNode.insertBefore(novoTel, phoneGroup.nextSibling);
});

// Ao clicar no botão Novo contato a classe btn-primary deve ser substituida por btn-success

let novoContato = document.getElementById("newContact");

novoContato.addEventListener("click", event =>{
    event.preventDefault;
    
    novoContato.classList.remove("btn-primary");
    novoContato.classList.add("btn-success");   
    alert();
});