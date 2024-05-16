using System;

namespace AntraPaskaita
{
    public class ProgramWhile1
    {
        public static void Main(string[] args)
        {
            //1. Užduotis: Skaičių sekos suma. Parašykite programą,
            //kuri naudoja while ciklą, kad suskaičiuotų visų teigiamų skaičių, mažesnių nei nurodytas skaičius 𝑛
            //n, suma.Programa turi paprašyti vartotojo įvesti skaičių 𝑛
            //n ir tada išvesti suskaičiuotą sumą.

            int startingNumber = 0;
            int n = 0;
            int result = 0;

            Console.WriteLine($"Iveskite skaiciu...");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n))
            {
                Console.WriteLine($"Įvestas skaičius: {n}");
            }
            else
            {
                Console.WriteLine("Įvestas netinkamas skaičiaus formatas.");
            }
            while (startingNumber<n)
            {
                result += startingNumber;
                startingNumber++;
            }

            Console.WriteLine($"Visų teigiamų skaičių, mažesnių nei nurodytas skaičius suma: {result}");
        }
    }
}

