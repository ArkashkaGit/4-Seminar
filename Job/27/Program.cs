/*
Задача 27: 
Напишите программу, 
которая принимает на вход число
и выдаёт сумму цифр в числе.

пример:
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число..");
int number = int.Parse(Console.ReadLine());
int sum = 0;
int i = 0;

while (number != 0)
{
    i = number % 10;
    sum = sum + i;
    number = number / 10;
}
Console.WriteLine($"сумма цифр заданного числа равна..\n{sum}");


/*
Console.WriteLine("введите число..");
string number = Console.ReadLine();
int ed = 0;
int sum = 0;

for (int i = 0; i< number.Length; i++)
{
sum = sum + number[i];
Console.WriteLine(sum);
}
Файл не выбран
Ещё
*/