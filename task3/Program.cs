internal class Program
{
    private static void Main(string[] args)
    {
        /*Задача 3: 
         Задайте произвольный массив.Выведете его элементы, 
         начиная с конца.Использовать рекурсию, 
         не использовать циклы.*/

        int[] printMass(int[] arr)
        {
            Console.Write(string.Join(", ", arr));
            Console.WriteLine();
            return arr;
            
        }

        int[] ReverseArray(int[] arr, int N)
        {
            int start = arr.Length - N;

            if (N > arr.Length / 2)
            {
                int temp = arr[start];
                arr[start] = arr[N - 1];
                arr[N - 1] = temp;
                ReverseArray(arr, N - 1);
            }
            return arr;
        }

        int[] arr = { 2,5,7,4,8,3,5 };
        printMass(arr);
        printMass(ReverseArray(arr, arr.Length));

    }
}