using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject enemy;
    public float speed;

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 2) *3+4;
        enemy.transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
