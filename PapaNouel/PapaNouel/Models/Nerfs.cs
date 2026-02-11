using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Models
{
    internal class Nerfs : IJouet
    {
        public string ObsolescenceProgramee()
        {
            return "Ce produit cassera dans 2 heures";
        }

        public string Play()
        {
            return "Tirer sur les gens c'est fun";
        }
    }
}
