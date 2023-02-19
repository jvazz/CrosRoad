using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public GameObject plataforma1, plataforma2, plataforma3, plataforma4, plataforma5;
    GameObject player;
    public bool spawnou = false;
    public float tempo = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawnou)
        {
            if((player.transform.position.z - transform.position.z) > 20)
            {
                Spawnar();
            }
        }

        if(spawnou)
        {
           tempo += Time.deltaTime;

           if(tempo >= 5)
           {
                tempo = 0;
                spawnou = false;
           }
        }
    }

    void Spawnar()
    {
        int aleatorio;
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 60);
        aleatorio = Random.Range(0, 6);
        if(aleatorio == 1)
        {
            spawnou = true;
            Instantiate(plataforma1, new  Vector3(transform.position.x, transform.position.y, transform.position.z + 60), Quaternion.identity);
            Invoke("Destruir", 1f);
        }
        if(aleatorio == 2)
        {
            spawnou = true;
            Instantiate(plataforma2, new  Vector3(transform.position.x, transform.position.y, transform.position.z + 60), Quaternion.identity);
            Invoke("Destruir", 1f);
        }
        if(aleatorio == 3)
        {
            spawnou = true;
            Instantiate(plataforma3, new  Vector3(transform.position.x, transform.position.y, transform.position.z + 60), Quaternion.identity);
            Invoke("Destruir", 1f);
        }
        if(aleatorio == 4)
        {
            spawnou = true;
            Instantiate(plataforma4, new  Vector3(transform.position.x, transform.position.y, transform.position.z + 60), Quaternion.identity);
            Invoke("Destruir", 1f);
        }
        if(aleatorio == 5)
        {
            spawnou = true;
            Instantiate(plataforma5, new  Vector3(transform.position.x, transform.position.y, transform.position.z + 60), Quaternion.identity);
            Invoke("Destruir", 1f);
        }
    }

    /*void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Spawnar();
        }
    }*/

    void Destruir()
    {
        Destroy(gameObject);
    }
}
