/*
* (Matt Kirchoff)
* (File Name)
* (Assignment1)
* (Describe, in general, the code contained.)
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment1
{
    public class EnemySimulator : MonoBehaviour
    {
        public Enemy enemy;

        void Start()
        {
            enemy = new FastEnemy();

            enemy.DoMove();
        }

    }


}

