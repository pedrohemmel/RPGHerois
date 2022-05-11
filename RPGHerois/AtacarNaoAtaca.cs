using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHerois
{
    class AtacarNaoAtaca : IAtacarComArma
    {
        public void atacar()
        {
            Console.WriteLine("Eu não consigo atacar, estou machucado, desculpa amigos :(");
        }
    }
}
