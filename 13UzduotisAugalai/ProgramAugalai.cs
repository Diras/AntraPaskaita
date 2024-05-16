using System;

namespace AntraPaskaita
{
    public class ProgramAugalai
    {
        public static void Main(string[] args)
        {
            //  Sukurkite masyvą su dešimties augalų pavadinimais.
            //  Atspausdinkite kiekvieną uždavinio augalą atskiroje eilutėje.
            //  Atspausdinkite uždavinio kiekvieną augalą pradedant nuo paskutinio, ir baigiant pirmuoju. (atvirkščias ciklas).
            //  Suskaičiuokite kiek uždavinio masyve yra žodžių trumpesnių nei 5 simboliai, ir kiek ilgesnių nei 7 simboliai. (du skaičiavimai)
            //  Suskaičiuokite kiek uždavinio masyve yra žodžių ilgesnių nei 5 simboliai bet trumpesnių nei 10 simboliai. (tarp 5 ir 10 simbolių ilgio)


            string[] crops = new string[10];

            crops[0] = "Kviečiai";
            crops[1] = "Kukurūzai";
            crops[2] = "Ryžiai";
            crops[3] = "Miežiai";
            crops[4] = "Pupelės";
            crops[5] = "Bulvės";
            crops[6] = "Pomidorai";
            crops[7] = "Medvilnė";
            crops[8] = "Morkos";
            crops[9] = "Salotos";


            Console.WriteLine("Augalu sarasas:");
            foreach (string crop in crops)
            {
                Console.WriteLine(crop);
            }

            Console.WriteLine();

            Console.WriteLine("Augalu sarasas atvirksciai:");
            for (int i = crops.Length-1; i > 0; i--)
            {
                Console.WriteLine(crops[i]);
            }

            int lessThan5Simbols = 0;
            int moreThan7Simbols = 0;

            for (int i = 0; i < crops.Length; i++)
            {
                if(crops[i].Length < 5)
                {
                    lessThan5Simbols++;
                }
                if(crops[i].Length > 7)
                {
                    moreThan7Simbols++;
                }


            }
            Console.WriteLine();
            Console.WriteLine($"Masyve yra žodžių trumpesnių nei 5 simboliai: {lessThan5Simbols}");
            Console.WriteLine($"Masyve yra žodžių ilgesnių nei 7 simboliai: {moreThan7Simbols}");

            int moreThan5LessThan10 = 0;

            for (int i = 0; i < crops.Length; i++)
            {
                if (crops[i].Length > 5 && crops[i].Length < 10)
                {
                    moreThan5LessThan10++;
                }
               
            }

            Console.WriteLine();
            Console.WriteLine($"Masyve yra žodžių ilgesnių nei 5 simboliai ir trumpesnių nei 10 simboliu : {moreThan5LessThan10}");
        }

    }
}
