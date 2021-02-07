using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletDirection;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletDirection.transform.position, bulletDirection.transform.rotation);
        bullet.SetActive(true);
    }
}
