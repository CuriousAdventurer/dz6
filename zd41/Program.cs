﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 4

Console.Write("Введите любое количество чисел через пробел: ");
int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");