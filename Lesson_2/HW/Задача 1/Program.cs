// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трехзначное число:");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3)
{
    int result = (Value / 10) % 10;
    Console.WriteLine("Вторая цифра " + result);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}


