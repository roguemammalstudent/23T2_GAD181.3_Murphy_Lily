using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    private void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("lever triggered");
            Door.SetActive(!Door.activeInHierarchy);
        }
    }
}
