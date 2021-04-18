using System;
using FMODUnity;
using UnityEngine;
using UnityEngine.VFX;

namespace Actor.Obstacle
{
    public class BlowingObstacle : StaticObstacle
    {
        public VisualEffect vfx;

        public float distance = 1.0f;

        public float timeBeforeBlowing;
        private CooldownTimer _timerBlowing;

        public float timeActive;
        private CooldownTimer _timerActive;

        public GameObject[] aoe;

        public StudioEventEmitter emitter;

        protected override void OnStart()
        {
            base.OnStart();

            foreach (GameObject o in aoe)
            {
                o.SetActive(false);
            }

            _timerActive = new CooldownTimer(timeActive);
            _timerActive.TimerCompleteEvent += TimerActiveOnTimerCompleteEvent;
            
            _timerBlowing = new CooldownTimer(timeBeforeBlowing);
            _timerBlowing.Start();
            _timerBlowing.TimerCompleteEvent += TimerBlowingOnTimerBlowingCompleteEvent;
        }

        private void TimerActiveOnTimerCompleteEvent()
        {
            foreach (GameObject o in aoe)
            {
                o.SetActive(false);
            }
            _timerBlowing.Start();
        }

        private void TimerBlowingOnTimerBlowingCompleteEvent()
        {
            //woosh
            foreach (GameObject o in aoe)
            {
                o.SetActive(true);
            }
            _timerActive.Start();
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            _timerBlowing.Update(Time.deltaTime);
            _timerActive.Update(Time.deltaTime);
        }
    }
}