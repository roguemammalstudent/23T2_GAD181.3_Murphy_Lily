using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : MonoBehaviour
{

    public float speed = 10f;

    float movementX;
    float movementZ;

    Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(movementX * speed, 0, movementZ * speed);

        if (Input.GetKeyDown(KeyCode.W))
        {
            movementZ = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            movementZ = -1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            movementX = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            movementX = 1;
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            movementZ = 0;
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            movementX = 0;
        }

    }
}
