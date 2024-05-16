using System;

namespace AntraPaskaita
{
    public class ProgramWhile2
    {
        public static void Main(string[] args)
        {
            // Užduotis: Atvirkštinis skaičių išvedimas
            // Parašykite programą naudojant for ciklą, kuri paprašo vartotojo įvesti skaičių 𝑛
            // n ir tada išveda visus skaičius nuo 𝑛 iki 1 atvirkštine tvarka.
            // Kiekvienas skaičius turi būti atskirtas nauja eilute.

            Console.WriteLine("Įveskite skaičių:");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
            }

            if(n > 1)
            {
                for (int i = n; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; n <= i; i--)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
}
