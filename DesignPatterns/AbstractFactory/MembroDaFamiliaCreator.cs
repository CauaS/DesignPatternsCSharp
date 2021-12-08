namespace DesignPatterns.AbstractFactory
{
    //creator
    class MembroDaFamiliaCreator
    {
        public static MembroDaFamilia Criar(string nome, string grauParentesco)
        {
            return new MembroDaFamilia(nome, grauParentesco);
        }
    }
}


