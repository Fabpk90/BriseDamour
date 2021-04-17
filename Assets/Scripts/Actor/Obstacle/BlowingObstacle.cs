using System;
using UnityEngine;
using UnityEngine.VFX;

namespace Actor.Obstacle
{
    public class BlowingObstacle : StaticObstacle
    {
        public VisualEffect vfx;

        public float distance = 1.0f;

        public float timeBeforeBlowing;
        private CooldownTimer _timer;

        protected override void OnStart()
        {
            base.OnStart();

            _timer = new CooldownTimer(timeBeforeBlowing, true);
            _timer.Start();
            _timer.TimerCompleteEvent += TimerOnTimerCompleteEvent;
        }

        private void TimerOnTimerCompleteEvent()
        {
            //woosh
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            _timer.Update(Time.deltaTime);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;

            var transform1 = transform;
            var position = transform1.position;
            Gizmos.DrawLine(position, position + transform1.up * distance);
        }
    }
}