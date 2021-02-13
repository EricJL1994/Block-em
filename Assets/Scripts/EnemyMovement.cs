using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject player;
    public float speed = 1;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Vector2 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.normalized.x * speed, rb.velocity.y);
    }
}
