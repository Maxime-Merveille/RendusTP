using PapaNouel.Decorator;
using PapaNouel.Factory;
using PapaNouel.Models;
using PapaNouel.Observer;

namespace PapaNouel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tp nouel");


            Bigfactory factory = new Bigfactory();

            factory.AddObserver(new MailObserver("Mail observer 1","test@test.com"));
            factory.AddObserver(new SMSObserver("SMS observer 1","06 12 34 56 78"));
            factory.AddObserver(new LogObserver("Logger observer 1 "));

            Console.WriteLine("\n\n===== Ajout des factory =====\n\n");

            factory.AddFactory("Playstation", new PlaystationFactory());
            factory.AddFactory("Poupee", new PoupeeFactory());
            factory.AddFactory("Nerfs", new NerfsFactory());

            Console.WriteLine("\n\n===== Creation des jouets =====\n\n");

            var play = factory.CreateJouet("Playstation");
            var poupee = factory.CreateJouet("Poupee");
            var nerfs = factory.CreateJouet("Nerfs");

            Console.WriteLine("\n\n===== Print des jouets =====\n\n");


            Console.WriteLine($"{play.Play()} || {play.ObsolescenceProgramee()}");
            Console.WriteLine($"{poupee.Play()} || {poupee.ObsolescenceProgramee()}");
            Console.WriteLine($"{nerfs.Play()} || {nerfs.ObsolescenceProgramee()}");

            Console.WriteLine("\n\n===== Decorateur de jouets =====\n\n");

            play = new MensongeDecorator(play);

            poupee = new RubanDecorator(poupee);

            Console.WriteLine($"{play.Play()} || {play.ObsolescenceProgramee()}");
            Console.WriteLine("\n");
            Console.WriteLine($"{poupee.Play()} || {poupee.ObsolescenceProgramee()}");
        }
    }
}
