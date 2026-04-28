// See https://aka.ms/new-console-template for more information
int idade, ano;

Console.WriteLine("Digite sua idade:");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano:");
ano = int.Parse(Console.ReadLine());

int total = idade * ano;

Console.WriteLine("O total de dias vividos é " + total);