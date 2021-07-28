using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particsc : MonoBehaviour
{
    public ParticleSystem partic;

    void Update()
    {
        if (Input.anyKey)
        {
            partic.Stop();
        }
    }
    private void OnParticleSystemStopped()
    {
        Debug.Log("over");
    }
    //Partikül sistemi bittiði zaman çalýþýr.
}
