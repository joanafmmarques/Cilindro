using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string r;
            double altura;
            double raio;
            double volume;
            double area;

            Console.WriteLine("Insira a altura do cilindro");
            a = Console.ReadLine();
            altura = Convert.ToDouble(a);

            Console.WriteLine("Insira o raio do cilindro");
            r = Console.ReadLine();
            raio = Convert.ToDouble(r);

            volume = Math.PI * raio * raio * altura;
            Console.WriteLine(volume);

            area = 2 * Math.PI * raio * (raio + altura);
            Console.WriteLine(area);

        }
    }
}
