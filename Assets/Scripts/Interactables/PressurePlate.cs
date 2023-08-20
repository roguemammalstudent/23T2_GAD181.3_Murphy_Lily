using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    [SerializeField] private GameObject Door;

    public DoorParticleController doorParticleController;

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
            doorParticleController.PlayParticleEffect();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door.SetActive(true);
            doorParticleController.PlayParticleEffect();
        }
    }
}
