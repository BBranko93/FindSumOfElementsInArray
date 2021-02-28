using System;

namespace FindSumOfElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum=0;
            int[] arr = new int[10];

            //Ask for the amount of elements in the array
            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            //Input all the numbers in the array
            Console.WriteLine("Input {0} number(s) to store in the array : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            //Add all the numbers in the array and print to screen
            for(i = 0; i<=arr[i]; i++)
            {
                sum += arr[i];
            }

            Console.Write("The sum of all elements stored in array is : {0}" ,sum);

        }
    }
}
