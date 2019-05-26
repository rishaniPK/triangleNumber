using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Input a number: ");
            int num =int.Parse(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = int.Parse(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;

            }
        }
    }
}