using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getcomponentparent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<BoxCollider>().enabled = false;



        //GetComponentInChildren<BoxCollider>().enabled = false;
        GetComponentInChildren<AudioSource>().mute = true;
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
}
