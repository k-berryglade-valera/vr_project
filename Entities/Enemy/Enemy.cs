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
        [SerializeField] private float _speedModifier;
        [SerializeField] private float _slowdownModifier;
        [SerializeField] private Animator _animator;
        private EnemyIK _enemyIK;
        private void Start()
        {
            
            Init();
        }

        private EnemyIK GetEnemyIK()
        {
            EnemyIK enemyIKComponent = GetComponent<EnemyIK>();
            return enemyIKComponent;
        }

        private bool Init()
        {
            _enemyIK = GetEnemyIK();
            _animator = GetComponent<Animator>();
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _navMeshAgent.speed = _speed * _speedModifier * _slowdownModifier;
            return true;
        }
        private bool ScanTarget()
        {
            if (SensorRaycast())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool SensorRaycast()
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
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
                
            }
            return false;
        }
        private bool SetName()
        {
            
            return true;
        }

        private void Move()
        {
            _navMeshAgent.SetDestination(_target.position);
        }
    
        private void Update()
        {
            if (ScanTarget())
            {
                Stop();
            }
            
            Move();
        }

        private void ContinueMove()
        {
            _slowdownModifier = 1.0f;
            _animator.SetBool("Walk", true);
        }
        
        private void Stop()
        {
            _slowdownModifier = 0.1f;
            _navMeshAgent.speed = _speed * _speedModifier * _slowdownModifier;
            _animator.SetBool("Idle", true);
        }

        private void OnAim()
        {
            _slowdownModifier = 0.1f;
            _animator.SetBool("Aim", true);
        }
    }
}