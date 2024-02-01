internal class Program
{
    private static void Main(string[] args)
    {
        /*Задача 3: 
         Задайте произвольный массив.Выведете его элементы, 
         начиная с конца.Использовать рекурсию, 
         не использовать циклы.*/

        //Функция печати массива
        int[] printMass(int[] arr)
        {
            Console.Write(string.Join(", ", arr));
            Console.WriteLine();
            return arr;
            
        }

        //Функция разворота массива с помощью рекурсии
        int[] ReverseArray(int[] arr, int N)
        {
            int i = arr.Length - N;

            if (N > arr.Length / 2)
            {
                int temp = arr[i];
                arr[i] = arr[N - 1];
                arr[N - 1] = temp;
                ReverseArray(arr, N - 1);
            }
            return arr;
        }
        //Массив и его печать
        int[] arr = { 2,5,7,4,8,3,5 };
        Console.WriteLine("Начальный массив: ");
        printMass(arr);
        Console.WriteLine("Перевернутый массив: ");
        printMass(ReverseArray(arr, arr.Length));

    }
}