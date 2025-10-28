using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameOverState : GameState
    {
        public GameState mainMenuState;
        public StoneSpawner spawner;

        public void Restart()
        {
            spawner.ClearStone();

            Exit();
            mainMenuState.Enter();
        }
    }
}
