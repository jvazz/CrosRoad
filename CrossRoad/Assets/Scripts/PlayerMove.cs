using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float velocidade;
    public float forcaPulo;
    public GameObject groundCheck;
    Rigidbody meuRig;
    bool taNoTronco = false;

    // Start is called before the first frame update
    void Start()
    {
        meuRig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(groundCheck.GetComponent<GroundCheck>().estaNoChao == true)
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                meuRig.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
                //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + 2), velocidade);
                meuRig.AddForce(Vector3.forward * forcaPulo, ForceMode.Impulse);
                //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + velocidade);
            }
            if(Input.GetKeyDown(KeyCode.S))
            {
                meuRig.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
                meuRig.AddForce(Vector3.forward * -forcaPulo, ForceMode.Impulse);
                //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - velocidade);
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                meuRig.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
                meuRig.AddForce(Vector3.right * -forcaPulo, ForceMode.Impulse);
                //transform.position = new Vector3(transform.position.x - velocidade, transform.position.y, transform.position.z);
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                meuRig.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
                meuRig.AddForce(Vector3.right * forcaPulo, ForceMode.Impulse);
                //transform.position = new Vector3(transform.position.x + velocidade, transform.position.y, transform.position.z);
            }

            if(!taNoTronco)
            {
                transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, Mathf.Round(transform.position.z));
                if(transform.position.z % 3 == 0)
                {
                    //Debug.Log("dvisivel");
                }else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);
                }
            }else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Round(transform.position.z));
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Tronco"))
        {
            taNoTronco = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name.Contains("Tronco"))
        {
            taNoTronco = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name.Contains("Tronco"))
        {
            taNoTronco = false;
        }
    }
}
