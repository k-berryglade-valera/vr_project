using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRApp.Entities.Enemy
{
    public class EnemyIK : MonoBehaviour
    {

        [SerializeField] private Transform rightHand;
        [SerializeField] private Transform leftHand;
        [SerializeField] private Transform rightFoot;
        [SerializeField] private Transform leftFoot;
        [SerializeField] private float rightHandWeight;
        [SerializeField] private float leftHandWeight;
        [SerializeField] private Animator animator;
    
        private void OnAnimatorIK(int layerIndex)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
            animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHandWeight);
            animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight);
            animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, leftHandWeight);
        
            animator.SetIKPosition(AvatarIKGoal.RightHand, rightHand.position);
            animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHand.position);
            animator.SetIKRotation(AvatarIKGoal.RightHand, rightHand.rotation);
            animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHand.rotation);
        }
    
    }
}


