using System;

namespace AntraPaskaita
{
    public class ProgramCiklai3
    {
        public static void Main(string[] args)
        {
            //  Užduotis: Skaičių filtravimas
            //  Parašykite programą, kurioje vartotojas įveda skaičių seriją į masyvą,
            //  o programa naudoja for ciklą ir if teiginį, kad atrinktų ir išvestų tik
            //  tuos skaičius, kurie yra didesni už vidutinę visų įvestų skaičių reikšmę.

            int arrayLength;
            int sum = 0;
            int average;
            

            Console.WriteLine("Įveskite kokio didzio masiva norite nauduoti:");

            while (!int.TryParse(Console.ReadLine(), out arrayLength))
            {
                Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
            }

            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Įveskite {i + 1} skaiciu:");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Įvestas netinkamas skaičiaus formatas. Bandykite dar kartą:");
                }

                array[i] = number;

            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            average = sum / array.Length;
            Console.WriteLine($"Vidurkis: {average}");

            for (int i = 0;i < array.Length; i++)
            {
                if(array[i] > average)
                {
                    Console.WriteLine($"Skaičius masyve didesnis uz vidurki: {array[i]}");
                }
            }


            
        }

    }
}
