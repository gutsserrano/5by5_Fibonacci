// Faça um programa que leia um numero inteiro e imprima até esta posição da sequencia fibonacci

int num;
int fib;
int ant;
int pos;
int option;

do
{
    fib = 1;
    ant = 0;
    pos = 1;

    do
    {
        Console.WriteLine("Digite quantos valores da sequência que irão aparecer:");
        num = int.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("\nValor deve ser maior que zero!\n");
        }
    } while (num <= 0);

    Console.Write("\n0 ");

    for (int i = 1; i < num; i++)
    {
        Console.Write(fib + " ");
        fib = ant + pos;
        ant = pos;
        pos = fib;
    }

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);
