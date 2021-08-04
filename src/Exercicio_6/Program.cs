using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************");
            Console.WriteLine("*********     Exercicio 6     *********");
            Console.WriteLine("***************************************");

            Console.WriteLine("");

            decimal Lado_Base;
            decimal Lado_Altura;
            decimal area;

            Console.Write("Digite a medida da Base do Retângulo: ");
            Lado_Base = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a medida da Altura do Retângulo: ");
            Lado_Altura = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("");

            area = Lado_Base * Lado_Altura;

            Console.WriteLine("***************************************");

            Console.WriteLine($"A área do retângulo conforme medidas informadas é de {area} m². ");

            Console.WriteLine("***************************************");

            Console.WriteLine("");

            Console.ReadKey();




        }
    }
}
