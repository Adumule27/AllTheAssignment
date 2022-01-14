using System;
namespace find_the_second_largest_number
{
    class program
    {
        static void Main(string[] args)
        {
            int larger = 0;
            int second = 0;
            int[] numbers = {
                  12,20,30,40,38
            };

            for (int i = 0; i < numbers.Length; i++)
            {



                if (numbers[i] > larger)
                {
                    second = larger;
                    larger = numbers[i];
                }
                else if (numbers[i] > second)
                {
                    second = numbers[i];
                }

            }
            System.Console.WriteLine(second);


        }


    }
}