using System;

namespace AntraPaskaita
{
    public class ProgramCiklas1
    {
        public static void Main(string[] args)
        {
            // Užduotis: Temperatūrų vidurkio skaičiavimas
            // Parašykite programą, kuri leidžia vartotojui įvesti temperatūras kelias dienas.
            // Masyvas turi būti naudojamas temperatūroms saugoti. Po to, kai visos temperatūros
            // įvestos, programa turi naudoti for ciklą, kad apskaičiuotų ir išvestų temperatūrų vidurkį.

            int numberOfDays;
            float result = 0;

            Console.WriteLine("Įveskite keliu dienu tiemperaturos vidurki norite apskaiciuoti:");

            while (!int.TryParse(Console.ReadLine(), out numberOfDays))
            {
                Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
            }

            float[] temperatureOfDays = new float[numberOfDays];

            for (int i = 0;  i < numberOfDays; i++)
            {
                Console.WriteLine($"Įveskite {i+1} dienos temperatura:");

                float temperature; 

                while (!float.TryParse(Console.ReadLine(), out temperature))
                {
                    Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
                }

                temperatureOfDays[i] = temperature;
                
            }

            for (int i = 0; i < temperatureOfDays.Length; i++)
            {
                result += temperatureOfDays[i];
            }

            result /= numberOfDays;

            Console.WriteLine($"{numberOfDays} dienu temperatūrų vidurkis = {result:F2}");
        }

    }
}
