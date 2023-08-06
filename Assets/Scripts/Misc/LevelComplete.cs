using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelComplete : MonoBehaviour
{
    private int wincount;
    private float delay = 1.5f;

    // Update is called once per frame
    private void Start()
    {
        wincount = 0;
    }

    private void Update()
    {
        if (wincount >= 2)
        {
            Invoke("loadNextLevel", delay);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wincount += 1;
            Debug.Log(wincount);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wincount -= 1;
            Debug.Log(wincount);
        }
    }



    void loadNextLevel()
    {
        Debug.Log("Load Next level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
