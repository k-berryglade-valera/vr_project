using System;
using System.Collections.Generic;
using VRApp;

namespace VRApp.Managers
{
    public class EnemyManager<EntityType> : Manager, IObservable, IInitializable, ICreater<EntityType>
    {
        private List<IObserver> _observers;
        
        public List<IObserver> Observers
        {
            get => _observers;
            set => _observers = value;
        }

        public EnemyManager()
        {
            Initialize();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                
            }
        }
    
        public bool Initialize()
        {
            _observers = new List<IObserver>();
            return true;
        }

        public void Init()
        {
            throw new System.NotImplementedException();
        }
        

        public bool CreateEntity<T>()
        {
            throw new NotImplementedException();
        }
    }
}