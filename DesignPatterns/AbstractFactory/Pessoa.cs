namespace DesignPatterns.AbstractFactory
{
    //abstract Product
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public abstract void EuSou();
    }
}


