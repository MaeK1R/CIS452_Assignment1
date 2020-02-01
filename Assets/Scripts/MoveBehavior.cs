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
    public class MoveFast : MonoBehaviour, IMoveBehavior
    {
        public Transform playerPos;
        public float speed = 5f;

        public void Update()
        {
            Move();
        }
        public void Move()
        {
            playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
    }
    public class MoveMid : MonoBehaviour, IMoveBehavior
    {
        public Transform playerPos;
        public float speed = 3f;
        public void Move()
        {
            playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
    }
    public class MoveSlow : MonoBehaviour, IMoveBehavior
    {
        public Transform playerPos;
        public float speed = 1f;
        public void Move()
        {
            playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
    }
}
