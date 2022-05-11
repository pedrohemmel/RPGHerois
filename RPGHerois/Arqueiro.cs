using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHerois
{
    class Arqueiro : Heroi
    {
        public Arqueiro(string nome) : base(nome)
        {
            this.atacarBehavior = new AtacarArco();
            this.atacarSecundariaBehavior = new AtacarMachado();
        }
    }
}
