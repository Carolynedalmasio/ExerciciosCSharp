// See https://aka.ms/new-console-template for more information
string nome1;
double venda1, comissao1;
Console.WriteLine("Digite o nome do vendedor:");
nome1 = Console.ReadLine();
Console.WriteLine("Digite o valor total das vendas de " + nome1 + " : ");
venda1 = double.Parse(Console.ReadLine());

if (venda1 < 50000) ;
{
    comissao1 = venda1 * 0.12;
}
if (venda1 >= 30000 && venda1 <= 50000)
{
    comissao1 = venda1 * 0.095;
}
else
{
    comissao1 = venda1 * 0.07;

}
Console.WriteLine("Nome: " + nome1);
Console.WriteLine("Valor da venda: " + venda1);
Console.WriteLine("Comissão: " + comissao1);



string nome2;
double venda2, comissao2;
Console.WriteLine("Digite o nome do vendedor: ");
nome2 = Console.ReadLine();
Console.WriteLine("Digite o valor total das vendas de " + nome2 + " : ");
venda2 = double.Parse(Console.ReadLine());

if (venda2 < 50000) ;
{
    comissao2 = venda2 * 0.12;
}
if (venda2 >= 30000 && venda2 <= 50000)
{
    comissao2 = venda2* 0.095;
}
else
{
    comissao2 = venda2 * 0.07;

}
Console.WriteLine("Nome: " + nome2);
Console.WriteLine("Valor da venda: " + venda2);
Console.WriteLine("Comissão: " + comissao2);


string nome3;
double venda3, comissao3;
nome3 = Console.ReadLine();
Console.WriteLine("Digite o valor total das vendas de " + nome3 + " : ");
venda3 = double.Parse(Console.ReadLine());

if (venda3 < 50000) ;
{
    comissao3 = venda3 * 0.12;
}
if (venda3 >= 30000 && venda3 <= 50000)
{
    comissao3 = venda3* 0.095;
}
else
{
    comissao3 = venda3 * 0.07;

}
Console.WriteLine("Nome: " + nome3);
Console.WriteLine("Valor da venda: " + venda3);
Console.WriteLine("Comissão: " + comissao3);

double total = venda1 + venda2 + venda3;

Console.WriteLine("O valor total das vendas da impresa é: " + total);