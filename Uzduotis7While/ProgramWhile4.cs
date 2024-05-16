using System;

namespace AntraPaskaita
{
    public class ProgramWhile4
    {
        public static void Main(string[] args)
        {
            // Užduotis: Parašykite programą kuri prašo įvesti intervalą NUO / IKI
            // ir jame atspausdina pirminius skaičius, skaičius kurie dalinasi iš 11 be liekanos

            Console.WriteLine("Įveskite intervalo pradžios skaičių (NUO):");
            int fromNumber;

            while (!int.TryParse(Console.ReadLine(), out fromNumber))
            {
                Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
            }

            Console.WriteLine("Įveskite intervalo pabaigos skaičių (IKI):");
            int toNumber;

            while (!int.TryParse(Console.ReadLine(), out toNumber))
            {
                Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
            }

            Console.WriteLine($"Pirminiai skaičiai nuo {fromNumber} iki {toNumber}:");


            for (int i = fromNumber; i <= toNumber; i++)
            {
                if (i % 11 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
