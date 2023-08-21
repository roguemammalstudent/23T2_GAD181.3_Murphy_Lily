using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    private float timer = 3f;
    private float timeCount;
    private bool active;

    public GameObject doorParticle;

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
                Instantiate(doorParticle, Door.transform.position, Quaternion.identity);
            }
        }
    }
    private void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            Debug.Log("button triggered");
            if (active == false)
            {
                Door.SetActive(!Door.activeInHierarchy);
                active = true;
                Instantiate(doorParticle, Door.transform.position, Quaternion.identity);
            }
        }
    }

}

