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
    public class MidEnemy : Enemy
    {
        public IMoveBehavior MoveBehavior;
        public IHealthBehavior HealthBehavior;
        private int health;

        public MidEnemy()
        {
            health = 2;
        }
        public override void Die()
        {
            Destroy(gameObject);
        }
        public void Update()
        {
            void OnCollisionEnter2D(Collision2D col)
            {
                HealthBehavior.ChangeHealth();
            }
            if (health < 1)
            {
                Die();
            }
        }
    }
}