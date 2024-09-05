var aluno = {
    nome: "Juquinha",
    matricula: 123456,
    nota: 9,
    frequencia: 0.8,
    imprimeNota: function () {
        console.log(`Nota: ${this.nota}`);
    },
    imprimeFrequencia: function(){
        console.log(`Frequência: ${this.frequencia}`);
    },
    verificaAprovacao: function(media,frequencia){
        if((this.nota >= media) && 
        (this.frequencia >= frequencia)){
            return true;
        }else{
            return false;
        }
    }
};

aluno.imprimeNota();

aluno.aprovado = aluno.verificaAprovacao(7,0.75);