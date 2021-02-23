using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static Stats instance;
    public int speed = 2;
    public int damage = 5;
    public int bulletSpeed = 10;
    public float bulletLifespan = 0.5f;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
}
