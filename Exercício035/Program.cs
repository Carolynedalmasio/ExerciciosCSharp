// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Net.Http.Headers;
int Por, Mat, Ge, media;
string situacao;
string nome;
Console.WriteLine("Digite o seu nome:");
nome = Console.ReadLine();
Console.WriteLine("Digite a nota de Português:");
Por = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a notab de Matemática:");
Mat = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota de Conhecimentos Gerais:");
Ge = int.Parse(Console.ReadLine());
media = (Por + Mat + Ge) / 3;
Console.WriteLine("situação");

if (media > 7 & Por >= 5 & Mat >= 5 & Ge >= 5)
{
    situacao = "Aprovado";

}
else{
    situacao = "Reprovado";
}
    
Console.WriteLine("Média: " + media.ToString() + "<br>");
Console.WriteLine("Situação: " + situacao);

