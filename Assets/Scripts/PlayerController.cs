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

    private void Update()
    {

        if (Input.GetKey(forwardKey))

        {
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(backKey))

        {
            transform.position += Vector3.back * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(leftKey))

        {
            transform.position += Vector3.left * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(rightKey))

        {
            transform.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
    }
}
