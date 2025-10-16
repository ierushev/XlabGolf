using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class StoneSpawner : MonoBehaviour
    {
        public GameObject[] Rocks;

        public void Spawn()
        {
            var rock = GetRandomRock();
            Instantiate(rock);
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
