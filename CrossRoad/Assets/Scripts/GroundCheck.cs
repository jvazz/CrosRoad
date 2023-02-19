using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool estaNoChao = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Ground")
        {
            estaNoChao = true;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if(col.tag == "Ground")
        {
            estaNoChao = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.tag == "Ground")
        {
            estaNoChao = false;
        }
    }
}
