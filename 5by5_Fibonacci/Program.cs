﻿// Faça um programa que leia um numero inteiro e imprima até esta posição da sequencia fibonacci

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

    Console.WriteLine("Digite quantos valores da sequência que irão aparecer:");
    num = int.Parse(Console.ReadLine());

    for (int i = 0; i < num; i++)
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