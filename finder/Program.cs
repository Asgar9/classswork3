using System;

namespace finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int[] com = { 3, 7, 5, 9 };
            Console.WriteLine(finder(num,com));
        }
        static int finder(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    return i;
                }
              
            }
             return -1;
        } 
    }
}
