using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Models
{
    class Playstation : IJouet
    {
        public string ObsolescenceProgramee()
        {
            return "Dans 4 ans elle marche plus";
        }

        public string Play()
        {
            return "Jouer c'est bien, mais 70 euros le jeu";
        }
    }
    
}
