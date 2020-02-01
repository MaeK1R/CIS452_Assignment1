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
    public interface IMoveBehavior
    {
        void Move();
    }
    public interface IHealthBehavior
    {
        int ChangeHealth();       
    }   
}

