// Positivos e media
// Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.
// Entrada
// A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.
// Saída
// O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.

// let soma,cont= 0;
// let v1 = parseFloat(gets());
// let v2 = parseFloat(gets());
// let v3 = parseFloat(gets());
// let v4 = parseFloat(gets());
// let v5 = parseFloat(gets());
// let v6 = parseFloat(gets());
// const positives = [v1, v2, v3, v4, v5, v6];

// let soma = positives.reduce(function(soma, i) {
//     return soma + i;
// })
// for (let i= 0; i < 6; i++) {
//   if (positives[i] > 0) {
//      cont++;
//   }
// }

// let media = parseFloat(soma / cont);

// console.log(cont + " valores positivos");
// console.log(media).toFixed(1);

// const input = require('fs').readFileSync('/dev/stdin', 'utf8');
// const lines = input.split('\n');

const positives = [];
let soma = 0;
let contador = 0;

for (let i = 0; i < 6 ; i++) {
  const numero = Number(lines.shift());
  if ( numero  >= 0 ) {
    positives.push(numero);
    contador++;
    soma += numero;
  }
}

const average = soma/contador;

console.log(contador + " valores positivos");
console.log(average.toFixed(1));

var pos = 0;
var media = 0;
var total = 0;

for(var i = 0; i < 6; i++){
 var valor = parseFloat(gets());
 if(valor > 0){
   pos++;
   total= total+valor
 }
}
media = (total/pos).toFixed(2);
console.log(pos + " valores positivos");
console.log(media[0]+"."+arredonda(media[2],media[3]));
function arredonda(num,numFatorArredondamento) {
 if(numFatorArredondamento > 5) {
   return parseInt(num)+1;//vai dar mais um ao numero da frente
 }
   return num;//vai ficar com o mesmo numero
}
