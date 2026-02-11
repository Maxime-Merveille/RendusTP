using PapaNouel.Factory;
using PapaNouel.Models;
using PapaNouel.Observer;
using System;
using System.Collections.Generic;
using System.Text;


namespace PapaNouel.Simulation
{
    public class Simulation
    {
        public List<IJouet> GetJouets()
        {
            List<IJouet> jouets = new List<IJouet>();
            Bigfactory factory = new Bigfactory();

            factory.AddObserver(new MailObserver("Mail observer 1", "test@test.com"));
            factory.AddObserver(new SMSObserver("SMS observer 1", "06 12 34 56 78"));
            factory.AddObserver(new LogObserver("Logger observer 1 "));

            Console.WriteLine("\n\n===== Ajout des factory =====\n\n");

            factory.AddFactory("Playstation", new PlaystationFactory());
            factory.AddFactory("Poupee", new PoupeeFactory());
            factory.AddFactory("Nerfs", new NerfsFactory());

            Console.WriteLine("\n\n===== Creation des jouets =====\n\n");

            var play = factory.CreateJouet("Playstation");
            var poupee = factory.CreateJouet("Poupee");
            var nerfs = factory.CreateJouet("Nerfs");

            jouets.Add(play);
            jouets.Add(poupee);
            jouets.Add(nerfs);

            return jouets;  
        }
    }
}
