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
    public abstract class Enemy : MonoBehaviour
    {
        public IMoveBehavior MoveBehavior;

        public IHealthBehavior HealthBehavior { get; set; }

        public virtual void DoMove() { MoveBehavior.Move(); }

        public virtual void DoHealth() { HealthBehavior.ChangeHealth(); }

        public abstract void Die();


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        public void Update()
        {

        }
    }
}

