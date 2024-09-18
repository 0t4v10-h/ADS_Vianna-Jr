class Calculadora {
    constructor(gasolina, alcool) {
        this.gasolina = gasolina
        this.alcool = alcool
    }

    calcular(){
        return this.gasolina * 0.7
    }

    preco(){
        let precoGaso = this.calcular()

        if(precoGaso < this.alcool){
            return this.gasolina
        }else{
            return this.alcool
        }
    }

    vantajoso(){
        let precoGaso = this.calcular()

        if(precoGaso < this.alcool){
            return "Gasolina"
        }else{
            return "Álcool"
        }
    }
}

export default Calculadora