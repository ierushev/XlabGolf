using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class StoneSpawner : MonoBehaviour
    {
        public GameObject[] Rocks;

        public void ClearStone()
        {
            GameObject[] stones = GameObject.FindGameObjectsWithTag("Stone");
            foreach (GameObject stone in stones)
            {
                Destroy(stone);
            }

        }
        public StoneSpawner spawner;
        public float minDelay = 2f;
        public float maxDelay = 6f;
        public bool isGameOver = false;

        private void Start()
        {
            StartSpawn();
        }

        public void StartSpawn()
        {
            StartCoroutine(StartRock());
        }

        IEnumerator StartRock()
        {
            do
            {
                float randomDelay = UnityEngine.Random.Range(minDelay, maxDelay);
                yield return new WaitForSeconds(randomDelay);
                spawner.Spawn();
            }
            while (!isGameOver);
        }

        public GameObject Spawn()
        {
            var prefab = GetRandomRock();
            if (prefab == null)
            {
                return null;
            }

            return Instantiate(prefab, transform.position, Quaternion.identity);
        }


        GameObject GetRandomRock()
        {
            if(Rocks.Length == 0)
                return null;
            int i = UnityEngine.Random.Range(0,Rocks.Length);
            return Rocks[i];
        }

    }
}
