﻿// Задача 26. Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе.
// 465 -> 3
// 25 -> 2
// 257487 -> 6

// //------------------------  START  -----------------------------------------------------------------

// int DataEntry(string str) // метод ввода числа
// {
//     Console.WriteLine(str);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }

// int CountHunter(int number) // метод подсчёта количества цифр
// {
//     int count = 0;
//     if (number < 0) number = -number;
//     for (int i = 0; number > 0; i++)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }

// //---------------------  РАБОЧАЯ ОБЛАСТЬ  ----------------------------------------------------------

// int number = DataEntry("Введите число: ");
// int count = CountHunter(number);

// Console.WriteLine($"Количество цифр:  {count}");

// ----------------------  END  --------------------------------------------------------------------

// +++++++++++++++++++  АЛЬТЕРНАТИВА  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//------------------------  START  -----------------------------------------------------------------

int DataEntry(string str) // метод ввода числа
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int CountHunter(int number) // метод подсчёта количества цифр
{
    int i = 0;
    if (number < 0) number = -number;
    for (i = 0; number > 0; i++)
    {
        number = number / 10;
    }
    return i;
}

//---------------------  РАБОЧАЯ ОБЛАСТЬ  ----------------------------------------------------------

int number = DataEntry("Введите число: ");
int count = CountHunter(number);

Console.WriteLine($"Количество цифр:  {count}");

// ----------------------  END  --------------------------------------------------------------------