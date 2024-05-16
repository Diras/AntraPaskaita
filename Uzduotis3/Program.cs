using System;

namespace AntraPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Atspausdinkite kas antrą skaičių nuo 10 iki 50 (porinius);

            for (int i = 10; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            } 
        }
    }
}

