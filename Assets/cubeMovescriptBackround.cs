using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovescriptBackround : MonoBehaviour
{

    public GameObject gameObject;
    public float spawnRate = 2;
    private float timer = 0;
    // yeet
    void Start()
    {
        Instantiate(gameObject, transform.position, transform.rotation);        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            Debug.Log("Timer +1");
            timer = timer + Time.deltaTime;
        }
        else
        {
            Debug.Log("move");
            Instantiate(gameObject, transform.position, transform.rotation);
            timer = 0;              
        }

    }
}
