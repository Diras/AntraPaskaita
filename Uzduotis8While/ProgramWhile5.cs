using System;

namespace AntraPaskaita
{
    public class ProgramWhile5
    {
        public static void Main(string[] args)
        {
            // Užduotis: Sukurkite programą, kuri naudoja while ciklą,
            // norint suskaičiuoti ir išvesti įvesto skaičiaus skaitmenų sumą.
            // Programa turi paprašyti vartotojo įvesti skaičių ir tada apskaičiuoti
            // bei išvesti skaitmenų sumą. Pvz., jei vartotojas įveda 123, programa turėtų išvesti 6 (1+2+3).


            Console.WriteLine("Įveskite skaiciu > 0:");
            int number;
            int result = 0;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
            }

            while (number > 0)
            {
                result += number%10;
                number /= 10;
            }

            Console.WriteLine(result);
        }

    }
}
