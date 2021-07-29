using System;

namespace PrintReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 elements in array (on new line)");
            for(int i=0; i< 10;i++)
            {
                arr[i] = Convert.ToInt32( Console.ReadLine());
            }
            Console.WriteLine("Array in reverse order: ");
            for(int i=arr.Length-1; i>=0;i--)
            {
                Console.Write("{0} ",arr[i]);
            }
        }
    }
}
