using System;

namespace Lectia5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In ce luna ati sadit cartofii?");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("pentru a afla perioada de recoltare apasa tasta A");
            
            string luna = Console.ReadLine();
            string A = Console.ReadLine();
            
            if (luna == "A")
            {
                int suma = a  + 4;
                Console.WriteLine("Vesti putea cultiva peste " + suma );
            
            
            }

            


        }
    }
}
