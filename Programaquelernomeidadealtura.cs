static void Main (string[] args){

//Programa que ler o nome, idade, altura e ano de nascimento.
//Exercicio de programação em C#

 Console.Writeline("Qual é o seu nome?");
 string nome = Console.Readline();

 Console.Writeline("Qual a sua idade?");
 int idade = Convert.Toint16 (Console.Readline());

 Console.Writeline("Qual a sua altura?");
 double altura = Conver.Todouble (console.Readline());

Console.Writeline("Seu nome é: {0}", nome);
Console.Writeline("Você tem {0}", idade "de idade");
Console.Writeline("É sua altura é {0}:", altura);

Console.Readkey();

}