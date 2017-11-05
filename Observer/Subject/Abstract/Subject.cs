using Observer.Observer.Interface;
using System.Collections.Generic;

namespace Observer.Subject.Abstract
{
    public abstract class Subject
    {
        protected IList<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer) => observers.Add(observer);

        public void Delete(IObserver observer) => observers.Remove(observer);

        public void Notify()
        {
            foreach (var item in observers)
                item.Update();
        }
    }
}
