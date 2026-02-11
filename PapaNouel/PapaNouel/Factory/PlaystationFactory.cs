using PapaNouel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Factory
{
    internal class PlaystationFactory : JouetFactory
    {
        public override IJouet CreateJouet()
        {
            return new Playstation();
        }
    }
}
