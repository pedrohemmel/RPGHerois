using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHerois
{
    class AtacarArco : IAtacarComArma
    {
        public void atacar()
        {
            Console.WriteLine("Acabei de atacar com um arco flecha");
        }
    }
}
