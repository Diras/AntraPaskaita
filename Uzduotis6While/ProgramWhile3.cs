using System;
using System.Drawing;

namespace AntraPaskaita
{
    public class ProgramWhile3
    {
        public static void Main(string[] args)
        {
            // Užduotis: Skaičių, kurie dalijasi iš 3, paieška
            // Sukurkite programą, kuri naudoja while ciklą norint rasti ir
            // išvesti pirmus 10 skaičių nuo 1 iki 100, kurie dalijasi iš 3
            // be liekanos. Programa turi išvesti šiuos skaičius vieną po kito, kiekvieną naujoje eilutėje.

            int n = 1;
            int numbersCount = 0;

            while (n<101)
            {
                if (n % 3 == 0)
                {
                    if(numbersCount < 10)
                    {
                        Console.WriteLine(n);
                        numbersCount++;
                    }

                }

                n++;
            }
        }
    }
}
