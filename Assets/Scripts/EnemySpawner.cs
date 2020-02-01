using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment1
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject enemy;
        public Transform[] spawnLocations;
        private float spawnDelay;
        public float spawnWait;


        void Start()
        {
            spawnDelay = spawnWait;
            InvokeRepeating("Spawn", spawnDelay, spawnDelay);

        }
        void Update()
        {
         
        }
        void Spawn()
        {
            int randPos = Random.Range(0, spawnLocations.Length);
            Instantiate(enemy, spawnLocations[randPos].position, Quaternion.identity);
        }
       

    }


}
