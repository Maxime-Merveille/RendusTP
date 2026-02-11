using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Models
{
    class Poupee : IJouet
    {
        public string ObsolescenceProgramee()
        {
            return "Tiendras au moins 5 ans";
        }

        public string Play()
        {
            return "Fait des truc de poupee";
        }
    }
  
}
