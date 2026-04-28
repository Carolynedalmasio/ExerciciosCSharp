// See https://aka.ms/new-console-template for more information
float salario, salarioFix, ComiCarros, ComiVendas, salarioTotal;
int carros, vendas;

Console.WriteLine("Digite o valor do salário:");
salario = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de carros vendidos:");
carros = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor total de vendas:");
vendas = int.Parse(Console.ReadLine());

salarioFix = salario * 2;
ComiCarros = carros * 58;
ComiVendas = vendas * (5 / 100);
salarioTotal = salarioFix + ComiCarros + ComiVendas;

Console.WriteLine("Salário fixo: " + salarioFix);
Console.WriteLine("Comissão por carros vendidos: " + ComiCarros);
Console.WriteLine("Comissão por vendas: " + ComiVendas);

Console.WriteLine("Salário total: " + salarioTotal);