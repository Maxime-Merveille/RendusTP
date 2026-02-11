using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Observer
{
    internal class SMSObserver : IObserver
    {
        private readonly string _phoneNumber;
        private readonly string _name;

        public SMSObserver(string name, string phoneNumber) 
        {
            _name = name;
            _phoneNumber = phoneNumber;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Observer : {_name}\nNouveau message au {_phoneNumber} : {message}\n");
        }
    }
}
