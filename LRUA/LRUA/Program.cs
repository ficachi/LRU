using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUA
{
    class Program
    {
        static int[,] Matriz = new int[3, 3];
        public static int input;
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el ultimo PageFrame");
            input = int.Parse(Console.ReadLine());
            LRU(input);
            Console.ReadKey();

        }

        private static void LRU(int input)
        {

            for (int j = 0; j < 3; j++)
            {
                Matriz[input, j] = 1;
            }
            for (int i = 0; i < 3; i++)
            {
                Matriz[i, input] = 0;
            }

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Matriz[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
