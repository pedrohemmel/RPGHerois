using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHerois
{
    class Guerreiro : Heroi
    {
        public Guerreiro(string nome) : base(nome)
        {
            this.atacarBehavior = new AtacarEspada();
            this.atacarSecundariaBehavior = new AtacarAdaga();
        }
    }
}
