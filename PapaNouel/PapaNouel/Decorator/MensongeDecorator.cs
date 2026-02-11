using DemoDesignPattern.Strucutural.Decorator;
using PapaNouel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Decorator
{
    internal class MensongeDecorator : JouetDecorator
    {
        public MensongeDecorator(IJouet Pizza) : base(Pizza)
        {
        }

        public override string ObsolescenceProgramee()
        {
            return base.ObsolescenceProgramee() + " , mais c'est le meilleur produit du marche !! Achetez le !!";
        }

        public override string Play()
        {
            return base.Play() + ", c'est vraiment le meilleur produit achetable aujourdhui !  ";
        }
    }
}
