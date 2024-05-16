using System;

namespace AntraPaskaita
{
    public class Program14
    {
        public static void Main(string[] args)
        {
            //  Sugeneruokite 300 atsitiktinių skaičių nuo 0 iki 300,
            //  atspausdinkite juos atskirtus tarpais ir suskaičiuokite kiek tarp jų yra didesnių už 150.
            //  Skaičiai didesni nei 275 turi būti atspausdinti skliausteliuose” [ ] “.-------

           

            int[] spartans = new int[300];
            string spartansText = "";
            int moreThan150 = 0;
           

            Random random = new Random();

            for (int i = 0; i <  spartans.Length; i++)
            {
                spartans[i] = random.Next(0, 301);

                if (spartans[i] > 275)
                {
                    spartansText += $" [{spartans[i]}]";
                }
                else
                {
                    spartansText += $" {spartans[i]}";
                }

                if (spartans[i] > 150)
                {
                    moreThan150++;
                }
                
                
            }
            
            Console.WriteLine(spartansText);
            Console.WriteLine();
            Console.WriteLine($"Skaiciu kiekis kurie didesni nei 150:{moreThan150}");




        }
    }
}
