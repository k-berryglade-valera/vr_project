using System;
using System.Collections.Generic;
using VRApp.Interfaces;

namespace VRApp.Managers.Delegates
{
    public class EnemyManager<T> : IObservable , IInitializable
    {
        List<IObserver> observers;
        
        public EnemyManager()
        {
            Initialize();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                
            }
        }
    
        public bool Initialize()
        {
            observers = new List<IObserver>();
            return true;
        }

        public void Init()
        {
            throw new System.NotImplementedException();
        }
    }
}