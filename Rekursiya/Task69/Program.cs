﻿/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/


Console.WriteLine("Введите A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B:");
int b = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumbers(a,b);
Console.WriteLine(degreeNumber);

int DegreeNumbers(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * DegreeNumbers(numA, numB-1);
}

