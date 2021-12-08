using DesignPatterns.AbstractFactory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var membroFamilia1 = Familia.CriaMembroDaFamilia("Cali", "Irmão");
            var membroFamilia2 = Familia.CriaMembroDaFamilia("Abemir", "Mãe");
            var membroFamilia3 = Familia.CriaMembroDaFamilia("Istela", "Irmã");

            membroFamilia1.InformacoesMembro();
            membroFamilia2.InformacoesMembro();
            membroFamilia3.InformacoesMembro();

            Console.ReadLine();
        }
    }
}


