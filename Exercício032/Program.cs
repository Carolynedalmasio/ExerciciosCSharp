// See https://aka.ms/new-console-template for more information
int N;
Console.WriteLine("Digite o valor de N: ");
N = int.Parse(Console.ReadLine());

if (N <= 10)
{
    Console.WriteLine("O valor de N é igual a f1");
}

else if (N >= 10 && N <= 100)
{
    Console.WriteLine("f2");
}

    else
    {
        Console.WriteLine("f3");
    }
    