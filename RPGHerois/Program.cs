using System;

namespace RPGHerois
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro pedro = new Guerreiro("Pedro Arcaidas");
            Arqueiro wellinston = new Arqueiro("Wellinston Ferreiro");

            pedro.mostraQuemFala();
            Console.WriteLine("Hoje estamos trilhando o caminho das neblinas em meio a guerra, a estraté... MEU DEUS! Estamos sendo atacados!!\n");

            wellinston.mostraQuemFala();
            wellinston.executaAtacar();

            Console.WriteLine("\n");

            pedro.mostraQuemFala();
            pedro.executaAtacar();

            Console.WriteLine("\n");

            wellinston.mostraQuemFala();
            wellinston.executaAtacarCArmaSecundaria();

            Console.WriteLine("\n");

            pedro.mostraQuemFala();
            pedro.executaAtacarCArmaSecundaria();

            Console.WriteLine("\n");

            pedro.mostraQuemFala();
            pedro.setAtacarBehavior(new AtacarNaoAtaca());
            pedro.executaAtacar();

            Console.WriteLine("\n");

            wellinston.mostraQuemFala();
            wellinston.executaAtacarCArmaSecundaria();

            Console.WriteLine("\n");

            Console.WriteLine("Dessa vez conseguimos escapar, mas vamos tomar mais cuidado das próximas vezes!\n\n");


        }
    }
}
