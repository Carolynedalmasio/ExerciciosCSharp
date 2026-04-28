// See https://aka.ms/new-console-template for more information
int A, B, C;
Console.WriteLine("Digite o valor de A: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C:");
C = int.Parse(Console.ReadLine());

int soma = A + B + C;

if (soma < C)
{
    Console.WriteLine("A soma de A + B é MENOR que C");
}
else if (soma > C)
{
    Console.WriteLine("A soma de A + B é MAIOR que C");
}
else
{
    Console.WriteLine("A soma de A + B é IGUAL que C");
}




