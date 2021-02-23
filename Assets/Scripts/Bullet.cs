using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(DestroyBullet());
    }

    void Update()
    {
        rb.velocity = transform.right * Stats.instance.bulletSpeed;
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(Stats.instance.bulletLifespan);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(Stats.instance.damage);
            Destroy(gameObject);
        }
    }
}
