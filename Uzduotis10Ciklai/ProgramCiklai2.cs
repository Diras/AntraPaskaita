using System;

namespace AntraPaskaita
{
    public class ProgramCiklai2
    {
        public static void Main(string[] args)
        {
            // Užduotis: Maksimalios ir minimalios reikšmės radimas
            // Sukurkite programą, kuri paprašo vartotojo įvesti skaičių
            // seriją į masyvą.Naudokite for ciklą, kad rastumėte didžiausią
            // ir mažiausią skaičius masyve.Panaudokite if sąlyginius teiginius,
            // kad nustatytumėte, kuris skaičius yra didžiausias, o kuris -mažiausias, ir išveskite juos į ekraną.

            int arrayLength;
            int min = 0;
            int max = 0;
            
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

            for (int i = 1; i < array.Length; i++)
            {
                min = array[0];
                max = array[0];

                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }


            Console.WriteLine($"Didžiausias skaičius masyve: {max}");
            Console.WriteLine($"Mažiausias skaičius masyve: {min}");
        }

    }
}
