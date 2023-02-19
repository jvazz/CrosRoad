using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeiculosIniciais : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name.Contains("Tronco"))
        {
            if(gameObject.name.Contains("_2"))
            {
                transform.position = new Vector3(transform.position.x - 3 * Time.deltaTime, transform.position.y, transform.position.z);
            }else
            {
                transform.position = new Vector3(transform.position.x + 3 * Time.deltaTime, transform.position.y, transform.position.z);
            }
        }
        if(gameObject.name.Contains("Carro") || gameObject.name.Contains("Caminhao"))
        {
            if(gameObject.name.Contains("_2"))
            {
                transform.position = new Vector3(transform.position.x - 4 * Time.deltaTime, transform.position.y, transform.position.z);
            }else
            {
                transform.position = new Vector3(transform.position.x + 4 * Time.deltaTime, transform.position.y, transform.position.z);
            }
        }
        if(gameObject.name.Contains("Trem"))
        {
            if(gameObject.name.Contains("_2"))
            {
                transform.position = new Vector3(transform.position.x - 20 * Time.deltaTime, transform.position.y, transform.position.z);
            }else
            {
                transform.position = new Vector3(transform.position.x + 20 * Time.deltaTime, transform.position.y, transform.position.z);
            }
        }

        if(transform.position.x > 55)
        {
            if(!gameObject.name.Contains("Trem"))
            {
                transform.position = new Vector3(-55, transform.position.y, transform.position.z);
            }else
            {
                if(transform.position.x > 80)
                {
                    transform.position = new Vector3(-80, transform.position.y, transform.position.z);
                }
            }
        }
        if(transform.position.x < -55)
        {
            if(!gameObject.name.Contains("Trem"))
            {
                transform.position = new Vector3(55, transform.position.y, transform.position.z);
            }else
            {
                if(transform.position.x < -80)
                {
                    transform.position = new Vector3(80, transform.position.y, transform.position.z);
                }
            }
        }
    }
}
