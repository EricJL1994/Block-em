using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    private void Start()
    {
        InvokeRepeating("Spawn",0,2);
    }
    public override void Spawn()
    {
        float rnd = Random.Range(0, totalChance);
        int i = 0;
        for (; i < objects.Length && objects[i].chance <= rnd; i++)
        {
            rnd -= objects[i].chance;
        }

        GameObject toSpawn = Instantiate(objects[i].spawneableGameObject, transform.position, Quaternion.identity);

    }
}
