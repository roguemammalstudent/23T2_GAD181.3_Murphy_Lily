using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    [SerializeField] private GameObject Door;

    public GameObject doorParticle;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door.SetActive(false);
            Instantiate(doorParticle, Door.transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door.SetActive(true);
            Instantiate(doorParticle, Door.transform.position, Quaternion.identity);
        }
    }
}
