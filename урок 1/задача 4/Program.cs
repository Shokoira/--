﻿// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int b =1;
while (a>=b)
{
    if (b%2==0)
    Console.Write($"{b} ");
    b=b+1;
}
