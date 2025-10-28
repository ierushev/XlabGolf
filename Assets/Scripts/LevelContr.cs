using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Golf
{
    public class LevelContr : MonoBehaviour
    {
        public int score = 0;

        public int hightScore = 0;

        

        private void OnEnable()
        {
            GameEvents.onStickHit += OnStickHit;
            score = 0;

        }

        private void OnDisable()
        {
            GameEvents.onStickHit -= OnStickHit;

        }

        private void OnStickHit()
        {
            score++;
            hightScore = Mathf.Max(hightScore, score);

            //UnityEngine.Debug.Log($"score: {score} - hightScore: {hightScore}");
        }


    }
}