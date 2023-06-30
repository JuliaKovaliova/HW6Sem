﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Enter (string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32 (value);
    return result;
}

int [] InputArray (int length)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Enter ($"Enter {i + 1} element: ");
    }
    return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ($"a[{i}] = {array[i]} ");
    }
}

int CountPositiveNumbers ( int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int length = Enter ("Введите количество элементов: ");
int [] array = InputArray (length);
PrintArray (array);
Console.WriteLine ($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");