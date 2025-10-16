using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameManager : MonoBehaviour
    {
       public StoneSpawner spawner;
        public float delay = 1f;
        public bool isGameOver = false;

        private void Start()
        {
            StartCoroutine(StartRock());
        }

        IEnumerator StartRock()
        {
            do
            {
                yield return new WaitForSeconds(delay);
                spawner.Spawn();
            }
            while (!isGameOver);
        }


    }
}
