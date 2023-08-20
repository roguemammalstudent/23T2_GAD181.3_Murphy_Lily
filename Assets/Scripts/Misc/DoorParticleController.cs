using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private GameObject Door;

    public void PlayParticleEffect()
    {
        particleSystem.Play();
    }

    public void StopParticleEffect()
    {
        particleSystem.Stop();
    }

    // Lily created this from research and a bit of guidance from ChatGPT - thanks ChatGPT! and research
}
