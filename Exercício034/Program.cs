// See https://aka.ms/new-console-template for more information
int A, B, C,temp;
Console.WriteLine("Digite o primeiro valor: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor: ");
C = int.Parse(Console.ReadLine());
if (A > B)
{
    temp = A;
    A = B;
    B = temp;
}
if (A > C)
{
    temp = A;
    A = C;
    C = temp;
}
if (B > C)
{
    temp = B;
    B = C;
    C = temp;
}
Console.WriteLine("Valores em ordem crescente:<br>");
Console.WriteLine( A + " - " + B + " - " + C);