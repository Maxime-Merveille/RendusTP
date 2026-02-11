using DemoDesignPattern.Strucutural.Decorator;
using PapaNouel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Decorator
{
    internal class RubanDecorator : JouetDecorator
    {
        public RubanDecorator(IJouet Pizza) : base(Pizza)
        {
        }

        public override string ObsolescenceProgramee()
        {
            return base.ObsolescenceProgramee() + " , mais il y a un ruban mignon";
        }

        public override string Play()
        {
            return base.Play() + ", il faut juste retirer le ruban avant ";
        }
    }
}
