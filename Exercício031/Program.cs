// See https://aka.ms/new-console-template for more information
int A, B;
Console.WriteLine("Digite o valor de A: ");
A = int.Parse (Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
B = int.Parse (Console.ReadLine());

if (A > B)
{
    Console.WriteLine("O valor de A é maior que B");

}

else if (B > A)
{
    Console.WriteLine("O valor de B é maior que A");

}

else{
        Console.WriteLine("A é igual B");
}


