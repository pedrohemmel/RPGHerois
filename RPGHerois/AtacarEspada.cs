using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHerois
{
    class AtacarEspada : IAtacarComArma
    {
        public void atacar()
        {
            Console.WriteLine("Acabei de atacar com minha espada");
        }
    }
}
