using System;
using UnityEngine;
using UnityEngine.VFX;

namespace Actor.Obstacle
{
    public class BlowingObstacle : StaticObstacle
    {
        public VisualEffect vfx;

        public float distance = 1.0f;

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;

            var transform1 = transform;
            var position = transform1.position;
            Gizmos.DrawLine(position, position + transform1.up * distance);
        }
    }
}