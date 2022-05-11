using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHerois
{
    class AtacarMachado : IAtacarComArma
    {
        public void atacar()
        {
            Console.WriteLine("Acabei de bagaçar o inimigo com meu machado!");
        }
    }
}
