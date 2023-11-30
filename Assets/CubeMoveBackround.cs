using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveBackround : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = 33;
    // Start is cal`led before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
