using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHerois
{
    abstract class Heroi
    {

        protected IAtacarComArma atacarBehavior;
        protected IAtacarComArma atacarSecundariaBehavior;

        public void setAtacarBehavior(IAtacarComArma newAtacarBehavior)
        {
            this.atacarBehavior = newAtacarBehavior;
        }

        public void executaAtacar()
        {
            atacarBehavior.atacar();
        }

        public void executaAtacarCArmaSecundaria()
        {
            atacarSecundariaBehavior.atacar();
            Console.WriteLine("Fiz isso utilizando minha arma secundária!");
        }

        public String nome { get; private set; }

        public Heroi(String nome)
        {
            this.nome = nome;
        }

        public void mostraQuemFala()
        {
            Console.WriteLine("- " + this.nome + " ");
        }


    }
}
