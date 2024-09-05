import _ from 'lodash';

let array1 = ['Banana','Morango','Maça'];
let array2 = ['Banana','Morango','Uva'];
let diference = _.difference(array1,array2);
console.log(diference);

let var1 = 'var 1';
const cons1 = 12;

console.log(var1);

function soma(a,b) {
    let resultado = a + b;
    return resultado;
}

function sub(a,b) {
    let result = a - b;
    return result;
}

console.log(soma(2,3));
console.log(soma(5,8));

let resultMenos = sub(10,7);
console.log(resultMenos);