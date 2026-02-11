using PapaNouel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Factory
{
    internal class NerfsFactory : JouetFactory
    {
        public override IJouet CreateJouet()
        {
            return new Nerfs(); 
        }
    }
}
