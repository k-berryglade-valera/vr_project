using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

namespace VRApp.Entities.Enemy
{
    // PROTOTYPE
    public class Enemy : EnemyBehaviour
    {

        [SerializeField] private NavMeshAgent _navMeshAgent;
        [SerializeField] private float _speed;
        [SerializeField] private Transform _target;
        [FormerlySerializedAs("_sensor")] [SerializeField] private List<Transform> _sensors;
        
        private void ScanTarget()
        {
            SensorRaycast();
        }

        private void SensorRaycast()
        {
            RaycastHit info;
            foreach (Transform sensor in _sensors)
            {
                
                if (_target == null)
                {
                    if (Physics.Raycast(sensor.position,
                        sensor.forward,
                        out info,
                        Mathf.Infinity)) 
                    {
                        if (info.transform.CompareTag("Player"))
                        {
                            _target = info.transform;
                        }
                    }
                }
                
            }
        }
        private bool SetName()
        {

            return true;
        }

        private void Move()
        {
            
        }

        private void Update()
        {
            ScanTarget();
        }
    }
}