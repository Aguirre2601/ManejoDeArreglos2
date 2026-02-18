using System; 

namespace ManejoDeArreglos2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Variables.Array = new int[3, 5];
            Variables.Array2 = new int[5, 3];
            Variables.var_num = new Random();
            for (int f = 0; f <= 2; f++)
            {
                for (int c = 0; c <= 4; c++)
                {
                    Variables.Array[f, c] = Variables.var_num.Next(0, 9);
                    Console.Write(" " + Variables.Array[f, c]);
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
            for (int f = 0; f <= 4; f++)
            {
                for (int c = 0; c <= 2; c++)
                {
                    Variables.Array2[f, c] = Variables.Array[c, f];
                    Console.Write(" " + Variables.Array2[f, c]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("Presione cualquier tecla para SALIR");
            Console.ReadKey();
        }
    }
}