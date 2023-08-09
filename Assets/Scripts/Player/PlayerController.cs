using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float movementSpeed = 10f;

    [Header("Controls")]
    [SerializeField] private KeyCode forwardKey;
    [SerializeField] private KeyCode backKey;
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private KeyCode rightKey;
    [SerializeField] private Rigidbody rb;
    private float directionz;
    private float directionx;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {

        if (Input.GetKey(forwardKey))

        {
            directionz = 1 * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(backKey))

        {
            directionz = -1 * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(leftKey))

        {
            directionx = -1 * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(rightKey))

        {
            directionx =  1 * Time.deltaTime * movementSpeed;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(directionx, rb.velocity.y, directionz);
    }



}
