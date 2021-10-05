// DIFERENCA = (A * B - C * D).

// Entrada
// O arquivo de entrada contém 4 valores inteiros.

// Saída
// Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme  
// exemplo abaixo, com um espaço em branco antes e depois da igualdade.

// const input = require('fs').readFileSync('/dev/stdin', 'utf8');
// const lines = input.split('\n');

// const a = Number(lines.shift());
// const b = Number(lines.shift());
// const c = Number(lines.shift());
// const d = Number(lines.shift());
let a = gets();
let b = gets();
let c = gets();
let d = gets();
const prodAB = a * b;
const prodCD = c * d;

const dif = prodAB - prodCD;

const mensagem = 'DIFERENCA = '+dif;
console.log(mensagem);
