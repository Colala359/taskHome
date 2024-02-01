using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Задача 2: 
            Напишите программу вычисления функции Аккермана с помощью рекурсии. 
            Даны два неотрицательных числа m и n.*/

        //Функция аккермана
        int Ack(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return Ack(m - 1, 1);
            else return Ack(m - 1, Ack(m, n - 1));
        }

        //Задаем значения M и N. Печать функции.
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N < 0 || M < 0) Console.WriteLine("Неверное значение.");

        Console.WriteLine(Ack(M, N));

    }
}
