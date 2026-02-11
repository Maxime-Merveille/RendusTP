using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Observer
{
    internal class LogObserver : IObserver
    {
        private readonly string _name;

        public LogObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Observer {_name}\nLogging : {message}");
        }
    }
}
