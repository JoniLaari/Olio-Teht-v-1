using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            Console.Write("Annoit luvun ");
            if (luku == 1)
                Console.WriteLine("yksi");
            else if (luku == 2)
                Console.WriteLine("kaksi");
            else if (luku == 3)
                Console.WriteLine("kolme");
            else
                Console.WriteLine("Et antanut lukua");
            Console.ReadLine();
        }
    }
}
