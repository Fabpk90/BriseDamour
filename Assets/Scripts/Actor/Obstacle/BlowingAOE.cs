using UnityEngine;

namespace Actor.Obstacle
{
    public class BlowingAOE : MonoBehaviour
    {
        public new CapsuleCollider collider;
        public BlowingObstacle obstacle;
    
        // Start is called before the first frame update
        void Start()
        {
            float distance = obstacle.distance;
            distance /= 2;
        
            collider.center += Vector3.up * distance / 2;
            collider.height = distance;
        }

        private void OnCollisionEnter(Collision other)
        {
            obstacle.OnCollision(other);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
