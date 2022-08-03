/*
Задача 25: 
Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/



Console.WriteLine("Введите первое число -A-...");
int firstNumber_A = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите второе число -B-...");
int secondNumber_B = int.Parse(Console.ReadLine());

int sqrt = 1;

for (int i=0; i<secondNumber_B; i++)
{
sqrt = sqrt * firstNumber_A;
}

Console.WriteLine("Число -A- возведено в натуральную степень числа -B-..");
Console.WriteLine(sqrt);
