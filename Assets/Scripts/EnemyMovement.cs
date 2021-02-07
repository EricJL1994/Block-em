using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject player;
    public float speed = 1;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 direction = player.transform.position - transform.position;
        rb.velocity = direction.normalized * speed;
    }
}
