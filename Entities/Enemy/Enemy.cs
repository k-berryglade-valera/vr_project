using UnityEngine;
using UnityEngine.AI;

namespace VRApp.Entities.Enemy
{
    // PROTOTYPE
    public class Enemy : EnemyBehaviour
    {

        [SerializeField] private NavMeshAgent _navMeshAgent;
        [SerializeField] private float _speed;
        [SerializeField] private Transform _target;
        
        private bool SetName()
        {

            return true;
        }

        private void Move()
        {
            
        }
        
    }
}