// See https://aka.ms/new-console-template for more information
int compra, pago, troco, resto, notas100, notas10, notas1;

Console.WriteLine("Digite o valor da compra:");
compra = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor pago:");
pago = int.Parse(Console.ReadLine());

troco = compra - pago;
resto = troco % 1000;
notas100 = troco / 100;
notas10 = resto / 100;
notas1 = resto;

Console.WriteLine("O valor da compra é " + compra);
Console.WriteLine("O valor pago é: " + pago);
Console.WriteLine("Troco: " + troco);

Console.WriteLine("Quantidade de notas de 100: " + notas100);
Console.WriteLine("Quantidade de notas de 10: " + notas10);
Console.WriteLine("Quantidade de notas de 1: " + notas1);