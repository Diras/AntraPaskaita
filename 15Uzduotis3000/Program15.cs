using System;

namespace AntraPaskaita
{
    public class Program15
    {
        public static void Main(string[] args)
        {

            //  Vienoje eilutėje atspausdinkite visus skaičius nuo 1 iki 3000,
            //  kurie dalijasi iš 77 be liekanos. Skaičius atskirkite kableliais.
            //  Po paskutinio skaičiaus kablelio neturi būti.

            string text = "";

            for (int i = 1; i < 3000; i++)
            {
                if(i % 77 == 0)
                {
                    text += $"{i}, ";
                }
            }

            text = text.Remove(text.Length-2);
            
            Console.WriteLine($"Skaiciai kurie dalijasi iš 77 be liekanos:{text}");




        }
    }
}
