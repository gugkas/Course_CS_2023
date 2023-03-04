// Напишите программу, которая выводит третью цифру заданного число или сообщает, что третьей цифры нет.




Console.Write("Введите  число:");
int Number = Convert.ToInt32(Console.ReadLine());


if (Number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10}");
else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

System.Console.WriteLine();


