// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int FindNumber(int num)
{
    return num/100%100;
}
Console.WriteLine(FindNumber(a));