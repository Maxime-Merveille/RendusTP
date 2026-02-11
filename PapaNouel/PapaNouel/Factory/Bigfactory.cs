using PapaNouel.Models;
using PapaNouel.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace PapaNouel.Factory
{
    internal class Bigfactory
    {
        private readonly Dictionary<string, JouetFactory> _factories = new Dictionary<string, JouetFactory>();

        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer); 
        }

        public void AddFactory(string Key, JouetFactory factory)
        {

            _factories.Add(Key, factory);
            TriggerObserver($"Nouvelle factory de type {Key} ajoutee!");
        }

        public IJouet CreateJouet(string Key)
        {
            if (!_factories.ContainsKey(Key)) throw new Exception($"Pas de factory pour le type {Key}");

            TriggerObserver($"Nouveau jouets de type {Key} cree!");

            return _factories[Key].CreateJouet();
        }

        public void TriggerObserver(string message)
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
