// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
//Например: 4 -> 16; -3 -> 9; -7 -> 49
Console.Clear();
Console.Write("Введите число:  ");
int number = int.Parse(Console.ReadLine()!);
int quatro = number * number;
Console.WriteLine($"Квадрат числа{number} равен {quatro}");
