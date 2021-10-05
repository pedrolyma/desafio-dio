// idade em dias
// Você terá o desafio de ler um valor inteiro  
// correspondente à idade de uma pessoa em dias e  
// informe-a em anos, meses e dias

// Obs.: apenas para facilitar o cálculo, considere todo  
// ano com 365 dias e todo mês com 30 dias. Nos casos de  
// teste nunca haverá uma situação que permite 12 meses  
// e alguns dias, como 360, 363 ou 364. 

// Entrada
// arquivo de entrada contém um valor inteiro.

// Saída
// Imprima a saída conforme exemplo fornecido.

let totalDeDias = parseInt(gets())
var ano = totalDeDias / 365;
var mes = ((totalDeDias % 365) / 30);
var dia = ((totalDeDias % 365) % 30);
console.log(ano.toFixed(0) + ' ano(s)');
console.log(mes.toFixed(0) + ' mes(es)');
console.log(dia + ' dia(s)');
