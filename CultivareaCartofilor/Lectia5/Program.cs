using System;

namespace Lectia5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In ce luna vei cultiva cartofii?");
            int laCeLunaVaGanditi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nu este posibil ca cartifii sa fie cultivati in aceasta luna");

            Console.WriteLine("Daca au fost saditi in lua a 3 - apasa A");
            Console.WriteLine("Daca au fost saditi in luna a 4 apasa B");
            string operatia = Console.ReadLine();


        }
    }
}
