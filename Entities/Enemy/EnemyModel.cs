
using VRApp.Hash;
using VRApp.Interfaces;

namespace VRApp.Entities.Enemy
{
    public class EnemyModel : IObserver, IInitializable
    {
        private EnemyDataNames _enemyNames;
        private HashManager _hashManager;
        
        /// <summary>
        /// Data from observer object
        /// </summary>
        private string _managerData;
        
        public string ManagerData
        {
            get => _managerData;
            private set => _managerData = value;
        }

        public EnemyModel()
        {
            Initialize();
        }
        
        public void Update(object obj)
        {
            string data = obj.ToString();
            ManagerData = data;
        }

        public bool Initialize()
        {
            _enemyNames = new EnemyDataNames("default");
            _hashManager = new HashManager();
            return true;
        }

        public void Init()
        {
            throw new System.NotImplementedException();
        }
    }
}