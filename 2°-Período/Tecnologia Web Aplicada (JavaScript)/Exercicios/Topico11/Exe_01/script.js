fetch('./caderneta.json').then(response =>{
    return response.json();

}).then(data =>{
    return data.Caderneta

}).then(caderneta =>{
    let codigo = `<ul> \n`;
    caderneta.forEach(contato => {
        codigo += `<li>${contato.nome}</li>`;
    });
    
    codigo += `</ul>`;
    document.body.innerHTML = codigo;
});