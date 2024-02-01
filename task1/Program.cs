﻿using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Задача 1: Задайте значения M и N.Напишите программу, 
          которая выведет все натуральные числа в промежутке от M до N. 
          Использовать рекурсию, не использовать циклы.*/

        void naturDigit(int M, int N)
        {
            if (N < M) return;
            naturDigit(M, N - 1);
            Console.Write($"{N} ");

        }

        
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N < M) Console.WriteLine("Неверное значение.");

        naturDigit(M, N);

    }
}