// See https://aka.ms/new-console-template for more information
string nome;
int parafuso, porca, arruela;
double total, totalParafusos, totalPorca, totalArruelas, precoParafuso, precoPorca, precoArruelas, totalDesconto,
    descParafuso, descPorcas, descArruelas;

Console.WriteLine("Digite o nome do cliente: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a quantidade de parafusos:");
parafuso = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de porcas:");
porca = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de Arruelas:");
arruela = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o preço do parafuso:");
precoParafuso = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço de porcas:");
precoPorca = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço de arruelas");
precoArruelas = double.Parse(Console.ReadLine());


totalParafusos = parafuso * precoParafuso * (20 / 100);
totalPorca = porca * precoPorca * (10 / 100);
totalArruelas = arruela * precoArruelas * (30 / 100);

descPorcas = totalPorca * (10 / 100);
descParafuso = totalParafusos * (20 / 100);
descArruelas = descPorcas * (30 / 100);

total = totalParafusos + totalPorca + totalArruelas;
totalDesconto = descParafuso + descPorcas + descArruelas;

Console.WriteLine("Cliente: " + nome);
Console.WriteLine("Parafusos: " + parafuso);
Console.WriteLine("Porcas: " +  porca);
Console.WriteLine("Arruelas: " +  arruela);
Console.WriteLine("Total do desconto: " + totalDesconto);
Console.WriteLine("Total a pagar: " + total);