using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Observer
{
    internal class MailObserver : IObserver
    {
        private readonly string _mailAdress;
        private readonly string _name;

        public MailObserver(string name, string mailAdress)
        {
            _name = name;
            _mailAdress = mailAdress;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Observer : {_name}\nNouveau e-mail au {_mailAdress} : {message}\n");
        }
    }

}
