using UnityEngine;

namespace Actor.Obstacle
{
    public class FollowPathObstacle : MonoBehaviour
    {
        public GameObject[] path;
        public int startingIndex;

        public float movementSpeed;

        private Vector3 _destination;
    
        // Start is called before the first frame update
        void Start()
        {
            _destination = GetNextDestinationPoint(ref startingIndex);
        }

        // Update is called once per frame
        void Update()
        {
            var localPosition = transform.position;
        
            transform.position = Vector3.MoveTowards(localPosition, _destination, movementSpeed * Time.deltaTime);

            if ((_destination - transform.position).sqrMagnitude < 0.01 * 0.01)
            {
                _destination = GetNextDestinationPoint(ref startingIndex);
            }
        }

        public Vector3 GetNextDestinationPoint(ref int index)
        {
            Vector3 point = path[index].transform.position;
            index++;

            if (index >= path.Length)
                index = 0;

            return point;
        }
    }
}
