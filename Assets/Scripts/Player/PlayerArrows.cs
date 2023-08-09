using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArrows : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementZ = 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movementZ = -1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movementX = -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movementX = 1;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            movementZ = 0;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            movementX = 0;
        }

    }
}
