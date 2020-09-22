using System;
using VRApp.Hash;

namespace VRApp.Entities.Enemy
{
    public class EnemyController : EnemyBehaviour, IInitializableEnemy
    {
        private HashManager _hashManager;
        private EnemyDataNames _enemyDataNames;
        private EnemyData _enemyData;

        public EnemyController()
        {
            _enemyDataNames = new EnemyDataNames();
        }
        public bool Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void Init()
        {
            throw new System.NotImplementedException();
        }

        public bool InitializeNames()
        {
            try
            {
                _hashManager = new HashManager();
                _enemyDataNames.Hashname = _hashManager.HashString(_enemyData.Name);
                return true;
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
    }
}