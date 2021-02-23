using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        DamagePopUp.Create(Vector3.zero, 10);
    }

    void Update()
    {
        
    }
}
