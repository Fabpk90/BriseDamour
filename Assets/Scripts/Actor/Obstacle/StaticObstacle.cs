using System;
using UnityEditor;
using UnityEngine;

namespace Actor.Obstacle
{
    [RequireComponent(typeof(Collider), typeof(Rigidbody))]
    public class StaticObstacle : MonoBehaviour
    {
        private void Start()
        {
            OnStart();
        }

        protected virtual void OnStart()
        {
            
        }

        private void Update()
        {
            OnUpdate();
        }

        public virtual void OnUpdate()
        {
            
        }

        private void OnCollisionEnter(Collision other)
        {
            OnCollision(other.transform);
        }

        public virtual void OnCollision(Transform other)
        {
            print("hit " + other.name);
        }
    }
}
