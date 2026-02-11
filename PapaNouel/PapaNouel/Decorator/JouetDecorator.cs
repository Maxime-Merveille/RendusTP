using PapaNouel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Strucutural.Decorator
{
    internal abstract class JouetDecorator : IJouet
    {
        protected readonly IJouet Jouet;

        protected JouetDecorator(IJouet jouet)
        {
            this.Jouet = jouet;
        }

        public virtual string ObsolescenceProgramee() => Jouet.ObsolescenceProgramee();
        public virtual string Play() => Jouet.Play();


    }
}
