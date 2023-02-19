using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if((player.transform.position.z - transform.position.z) > 10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15 * Time.deltaTime);
        }else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.3f * Time.deltaTime);
        }

        /*if(player.transform.position.x + transform.position.x > 10)
        {
            transform.position = new Vector3(transform.position.x - 15 * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if(player.transform.position.x - transform.position.x < 10)
        {
            transform.position = new Vector3(transform.position.x + 15 * Time.deltaTime, transform.position.y, transform.position.z);
        }*/
    }
}
