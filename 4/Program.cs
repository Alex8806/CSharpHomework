﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("ввести первое число =");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести второе число =");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести третье число =");
int num3 = Convert.ToInt32(Console.ReadLine());

if 
(num1>num2 && num1 > num3)
Console.WriteLine($"число {num1} максимальное");
else if 
(num2>num1 && num2 > num3)
Console.WriteLine($"число {num2} максимальное");
else 
Console.WriteLine($"число {num3} максимальное");



