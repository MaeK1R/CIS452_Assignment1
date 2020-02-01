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
    public class DecreaseHealth : MonoBehaviour, IHealthBehavior
    {
       
        public int ChangeHealth()
        {
            return -1;
        }
    }
    public class IncreaseHealth : IHealthBehavior
    {
        public int ChangeHealth()
        {
            return 1;
        }
    }
}
