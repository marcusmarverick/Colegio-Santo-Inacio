//codigo com a função de calculo e conversão// 

console.writeline("Quantos Votos Brancos?");
int brancos = convert.toint16 (console.readline());

console.writeline ("Quantos votos nulos?");
int nulos = converto.toint16 (console.readline());

console.writeline("Quantos votos válidos");
int validos = convert.toint16(console.readline());

double eleitores = brancos + nulos + validos;

double votos brancos = (brancos/eleitores)*100;
double votos nulos = (nulos/eleitores)*100;
double votos validos = (validos/ eleitores)*100;

contel.writeline ("total de eleitores:" +eleitores);

console.writeline ("votos brancos:"{0:0:00}%, votos brancos);
console.writeline ("votos nulos:" {0:0:00}%, votos nulos);
console.writeline ("votos válidos:" {0:0:00}% votos validos);
