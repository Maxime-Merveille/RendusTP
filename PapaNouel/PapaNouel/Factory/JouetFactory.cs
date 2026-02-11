using PapaNouel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Factory
{
    internal abstract class JouetFactory
    {
        public abstract IJouet CreateJouet();
    }
}
