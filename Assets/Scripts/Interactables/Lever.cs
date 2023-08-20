using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public DoorParticleController doorParticleController;

    [SerializeField] private GameObject Door;
    private void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            Debug.Log("lever triggered");
            Door.SetActive(!Door.activeInHierarchy);
            doorParticleController.PlayParticleEffect();
        }
    }
}
