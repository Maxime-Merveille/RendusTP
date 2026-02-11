using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Observer
{
    internal interface IObserver
    {
        public void Update(string message);
    }
}
