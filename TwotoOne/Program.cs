using System;
namespace two_dimension_two_one
{
    class program
    {
        static void Main(string[] args)
        {
            int[,] hold = {
                {23,1,56},
                {44,9,350},
                {63,4,90}
            };
            foreach (var item in hold)
            {
                System.Console.Write($"{item} \t");
            }
        }
    }
}