using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    private float timer = 3f;
    private float timeCount;
    private bool active;

    private void Update()
    {
        if (active == true)
        {
            timeCount += Time.deltaTime;

            if (timeCount >= timer)
            {
                Door.SetActive(!Door.activeInHierarchy);
                timeCount = 0;
                active = false;
            }
        }
    }
    private void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("button triggered");
            Door.SetActive(!Door.activeInHierarchy);
            active = true;
        }
    }

}
