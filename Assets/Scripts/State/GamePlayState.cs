using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Golf
{
    public class GamePlayState : GameState
    {
        public LevelContr levelContr;
        public StoneSpawner spawner;
        public PlayerContr playerContr;
        public GameState gameOverState;
        public TMP_Text scoreText;


        protected override void OnEnable()
        {
            base.OnEnable();
            levelContr.enabled = true;
            spawner.enabled = true;
            spawner.isGameOver = false;
            spawner.StartSpawn();
            playerContr.enabled = true;


            GameEvents.onCollisionStones += OnGameOver;
            GameEvents.onStickHit += OnStickHit;
            OnStickHit();
        }

        private void OnStickHit()
        {
            scoreText.text = $" Score: {levelContr.score}";
        }

        private void OnGameOver()
        {
            levelContr.enabled = false;
            spawner.isGameOver = true; 
            spawner.enabled = false;
            playerContr.enabled = false;
            Exit();
            gameOverState.Enter();
        }
        protected override void OnDisable()
        {
            base.OnDisable();

            GameEvents.onCollisionStones -= OnGameOver;

            levelContr.enabled = false;
            spawner.enabled = false;
            playerContr.enabled = false;
        }
    }
}
