using System;

namespace AntraPaskaita
{
    public class Program16
    {
        public static void Main(string[] args)
        {

            //  Nupieškite kvadratą iš “*”, kurio kraštines sudaro 25“*”

            char star = '*';
            string lineTopAndBottom = "";
            string middleLine = "";

            for (int i = 0; i < 25; i++)
            {
                lineTopAndBottom += star + " ";

                if (i == 0 || i == 24)
                {
                    middleLine += star + " ";
                }
                else
                {
                    middleLine += "  ";
                }
            }

            for (int i = 0;i < 25; i++)
            {
                if(i == 0 || i == 24)
                {
                    Console.WriteLine(lineTopAndBottom);
                }
                else
                {
                    Console.WriteLine(middleLine);
                }
            }

            int size = 25;  

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("* "); 
                    }
                    else
                    {
                        Console.Write("  ");  
                    }
                }
                Console.WriteLine();  
            }
        }
    }
}
