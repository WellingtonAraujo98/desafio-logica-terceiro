using desafioLogica.Models;

namespace desafioLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi heroi1 = new Heroi("Ronaldinho", 10, "mago");
            Heroi heroi2 = new Heroi("well", 90, "guerreiro");
            Heroi heroi3 = new Heroi("hamilton", 30, "ninja");
            Heroi heroi4 = new Heroi("Lebrom", 47, "monge");

            heroi1.Atacar();
            heroi2.Atacar();
            heroi3.Atacar();
            heroi4.Atacar();
        }
    }
}