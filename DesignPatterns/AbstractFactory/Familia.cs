namespace DesignPatterns.AbstractFactory
{
    class Familia
    {
        private readonly MembroDaFamilia _membroDaFamilia;
        public Familia(MembroFamiliaAbsractFactory membroFamiliaAbsractFactory, string nome, string parentesco)
        {
            _membroDaFamilia = membroFamiliaAbsractFactory.Criar(nome, parentesco);
        }

        public void InformacoesMembro() => _membroDaFamilia.EuSou();

        public static Familia CriaMembroDaFamilia(string nome, string parentesco)
        {
            return new Familia(new MembroFamiliaFactory(), nome, parentesco);
        }
    }
}


