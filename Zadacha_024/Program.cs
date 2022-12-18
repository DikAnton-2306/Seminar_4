// Задача 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int num)
{
    // пишем цикл от 1 до А
    // суммируем каждый итератор
    
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

// получить число от пользователя
int number = DataEntry("Введите число А: ");
int result = FindSum(number);
Console.WriteLine("Сумма всех чисел до А равняется " + result);