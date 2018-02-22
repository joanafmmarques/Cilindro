using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string r;
            double area;
            double raio;
            Console.WriteLine("Insira a altura do cilindro");
            a = Console.ReadLine();
            area = Convert.ToDouble(a);
            Console.WriteLine("Insira o raio do cilindro");
            r = Console.ReadLine();
            raio = Convert.ToDouble(r);
        }
    }
}
