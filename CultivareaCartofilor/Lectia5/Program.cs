using System;

namespace Lectia5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In ce luna ati sadit cartofii?");
            int luna = Convert.ToInt32(Console.ReadLine());

            int lunaRecoltei = luna + 4;
            Console.WriteLine("Vesti putea recolta in luna a " + lunaRecoltei);
        }
    }
}
