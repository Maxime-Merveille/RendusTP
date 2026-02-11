using PapaNouel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Factory
{
    internal class PoupeeFactory : JouetFactory
    {
        public override IJouet CreateJouet()
        {
            return new Poupee();
        }
    }
}
