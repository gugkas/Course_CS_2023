// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int num_1 = Convert.ToInt32(Console.ReadLine());

if (num_1 % 2 == 1)
{
    Console.WriteLine("Число является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число является: ЧЁТНЫМ");
}
