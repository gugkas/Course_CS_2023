﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.



Console.WriteLine("Введите число:");
string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = a % 2;

while (b <= a)
{
    if (b % 2 != 1)
    {

        Console.Write(b + " ");

    }
    b++;


}

