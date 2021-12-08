using System;

namespace DesignPatterns.AbstractFactory
{
    //concrete product
    class MembroDaFamilia : Pessoa
    {
        public string GrauParentesco { get; set; }
        public MembroDaFamilia(string nome, string grauParentesco) : base(nome)
        {
            GrauParentesco = grauParentesco;
        }
        public override void EuSou()
        {
            Console.WriteLine($"Eu sou o/a {base.Nome} e sou o/a {GrauParentesco}.");
        }
    }
}


