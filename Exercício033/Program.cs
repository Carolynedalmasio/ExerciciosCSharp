// See https://aka.ms/new-console-template for more information
int notaA, notaB, notaC, total;
Console.WriteLine("Digite a nota de A:");
notaA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota de B:");
notaB = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota de C:");
notaC = int.Parse(Console.ReadLine());
total = (notaA * 2) + (notaB * 3) + (notaC * 5 / 10);
Console.WriteLine("A média das notas é: " + total);
