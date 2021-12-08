namespace DesignPatterns.AbstractFactory
{
    //concrete Factory
    class MembroFamiliaFactory : MembroFamiliaAbsractFactory
    {
        public override MembroDaFamilia Criar(string nome, string grauParentesco)
        {
            return MembroDaFamiliaCreator.Criar(nome, grauParentesco);
        }
    }
}


