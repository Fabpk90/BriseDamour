using System;
using UnityEngine;

namespace Letter
{
    public class LetterManager : MonoBehaviour
    {
        public string pathData;

        public static LetterManager instance;

        private void Awake()
        {
            DontDestroyOnLoad(this);
            instance = this;
        }

        private void Start()
        {
            //load data
            //parse data
            //create the DB of letters
        }
    }
}