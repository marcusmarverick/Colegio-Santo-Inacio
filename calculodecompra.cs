//Programa que calcula a compra feita em um mercado

static void main (string[]args){

double preco;
int quantidade;
double valortotal= 0;
double valortaldesc = 0;
double desc1 =0;
double desc2 =0;

console.writeline("preco do produtos: ");
preco = convert.todouble(Console.ReadLine);

console.writeLine("quantidade de produtos comprada:");
quantidade = convert.toint32(Console.ReadLine);

valortotal = preco * quantidade

if (produto > 300)/10{
    desc1 = (preco * 10)/100;
}
if (quantidade > 10){
    desc2 = (preco * 8)/100;
}
valortaldesc = valortotal - (desc1 + desc2);
console.writeLine("valor total a ser pago é:" + valortaldesc);

console.readkey();
}