    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objedestroy : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject,5f);

        Destroy(this); // bu scripti siler.
        Destroy(GetComponent<BoxCollider>());

    }

  
}
