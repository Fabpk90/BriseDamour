using UnityEngine;

namespace Actor.Obstacle
{
    [RequireComponent(typeof(Collider), typeof(Rigidbody))]
    public class StaticObstacle : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            OnCollision(other);
        }

        public virtual void OnCollision(Collision other)
        {
            print("hit " + other.transform.name);
        }
    }
}
