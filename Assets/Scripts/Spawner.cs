using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Spawner : MonoBehaviour
{
    [Serializable]
    public struct SpawneableObject
    {
        public GameObject spawneableGameObject;
        public float chance;
    }

    public SpawneableObject[] objects;
    protected float totalChance = 0;

    private void Awake()
    {
        foreach (SpawneableObject o in objects)
        {
            totalChance += o.chance;
        }
    }

    public abstract void Spawn();
}
