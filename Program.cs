using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Insira a coordenada x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a coordenada y");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Encontra-se no primeiro quadrante");

            }


            if (x < 0 && y > 0)

                Console.WriteLine("Encontra-se no segundo quadrante");


            if (x < 0 && y < 0)
            {

                Console.WriteLine("Encontra-se no terceiro quadrante");
            }


            if (x > 0 && y < 0)
                Console.WriteLine("Encontra-se no quarto quadrante");



            Console.ReadLine();

        }
    }
}
