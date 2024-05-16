using System;

namespace AntraPaskaita
{
    public class ProgramCiklai4
    {
        public static void Main(string[] args)
        {
            //  Parašykite programą, kuri paprašo vartotojo įvesti tekstą.
            //  Naudokite for ciklą, kad suskaičiuotumėte ir išvestumėte kiekvienos raidės
            //  (A-Z, nepaisant didžiosios ar mažosios raidės) pasikartojimo skaičių tekste.
            //  Norėdami tai padaryti, galite naudoti 26 elementų masyvą,
            //  kur kiekvienas indeksas atitinka raidę (pvz., 0 atitinka A, 1 - B ir t.t.),
            //  o reikšmė masyve atitinka raidės pasikartojimo skaičių.


            Console.WriteLine("Įveskite teksta:");

            string text = Console.ReadLine().ToLower();

            int[] alphabet = new int[26];


            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    int index = currentChar - 'a';  
                    alphabet[index]++;  
                }
            }


            for (int i = 0;i < alphabet.Length;i++)
            {
                Console.WriteLine($"{(char)(i + 'a')} raidziu = {alphabet[i]}");
            }
        }

    }
}
