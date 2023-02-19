using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject plataforma1, plataforma2, plataforma3, plataforma4, plataforma5;
    public GameObject telaFimDeJogo, pausePanel;
    GameObject player;
    public float pontuacaoFloat = 0;
    public float pontuacaoTemporaria = 0;
    public Text pontuacaoTxt;
    public float pontuacaoMaisAlta = 0;
    bool mudouPontuacao = false;
    bool somouPontuacao = false;
    public GameObject cuboPlayer;
    public Color laranja;
    bool morto = false;
    bool pausado = false;

    // Start is called before the first frame update
    void Start()
    {
        PlataformasIniciais();
        telaFimDeJogo.SetActive(false);
        pausePanel.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player");

        if(PlayerPrefs.GetInt("texturaUsando") == 0)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = Color.white;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 1)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = Color.red;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 2)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = Color.blue;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 3)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 4)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = laranja;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 5)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = Color.green;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 6)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 7)
        {
            cuboPlayer.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y > 1.25f)
        {
            mudouPontuacao = true;
        }
        if(player.transform.position.y <= 1.25f)
        {
            if(mudouPontuacao)
            {
                mudouPontuacao = false;
                pontuacaoTemporaria = (transform.position.z + 6) / 3;

                if(pontuacaoTemporaria > pontuacaoFloat)
                {
                    pontuacaoFloat = pontuacaoTemporaria;
                }
                pontuacaoTxt.text = pontuacaoFloat.ToString("F0");

                if(pontuacaoMaisAlta < pontuacaoFloat)
                {
                    pontuacaoMaisAlta = pontuacaoFloat;
                }
                if(pontuacaoFloat < pontuacaoMaisAlta)
                {
                    pontuacaoFloat = pontuacaoMaisAlta;
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!morto)
            {
                if(!pausado)
                {
                    pausado = true;
                    pausePanel.SetActive(true);
                    Time.timeScale = 0;
                }
                else if(pausado)
                {
                    pausado = false;
                    pausePanel.SetActive(false);
                    Time.timeScale = 1;
                }
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Obstaculo")
        {
            if(!somouPontuacao)
            {
                morto = true;
                somouPontuacao = true;
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + (int)pontuacaoFloat);
                Time.timeScale = 0;
                telaFimDeJogo.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Agua")
        {
            if(!somouPontuacao)
            {
                morto = true;
                somouPontuacao = true;
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + (int)pontuacaoFloat);
                Time.timeScale = 0;
                telaFimDeJogo.SetActive(true);
            }
        }
        if(col.tag == "Obstaculo")
        {
            if(!somouPontuacao)
            {
                morto = true;
                somouPontuacao = true;
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + (int)pontuacaoFloat);
                Time.timeScale = 0;
                telaFimDeJogo.SetActive(true);
            }
        }
    }

    public void Recomecar()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void Pausar()
    {
        if(!morto)
        {
            if(!pausado)
            {
                pausado = true;
                pausePanel.SetActive(true);
                Time.timeScale = 0;
            }
            else if(pausado)
            {
                pausado = false;
                pausePanel.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void TelaInicial()
    {
        if(!somouPontuacao)
        {
            somouPontuacao = true;
            PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + (int)pontuacaoFloat);
        }
        SceneManager.LoadScene("TelaInicial");
        Time.timeScale = 1;
    }

    void PlataformasIniciais()
    {
        int aleatorio;
        aleatorio = Random.Range(1, 6);
        if(aleatorio == 1)
        {
            Instantiate(plataforma1, new  Vector3(transform.position.x, 0, 0), Quaternion.identity);
            //Instantiate(plataforma2, new  Vector3(transform.position.x, transform.position.y, 12), Quaternion.identity);
            //Instantiate(plataforma3, new  Vector3(transform.position.x, transform.position.y, 24), Quaternion.identity);
            //Instantiate(plataforma4, new  Vector3(transform.position.x, transform.position.y, 36), Quaternion.identity);
            //Instantiate(plataforma5, new  Vector3(transform.position.x, transform.position.y, 48), Quaternion.identity);
        }
        if(aleatorio == 2)
        {
            Instantiate(plataforma2, new  Vector3(transform.position.x, 0, 0), Quaternion.identity);
        }
        if(aleatorio == 3)
        {
            Instantiate(plataforma3, new  Vector3(transform.position.x, 0, 0), Quaternion.identity);
        }
        if(aleatorio == 4)
        {
            Instantiate(plataforma4, new  Vector3(transform.position.x, 0, 0), Quaternion.identity);
        }
        if(aleatorio == 5)
        {
            Instantiate(plataforma5, new  Vector3(transform.position.x, 0, 0), Quaternion.identity);
        }

        aleatorio = Random.Range(1, 6);
        if(aleatorio == 1)
        {
            Instantiate(plataforma1, new  Vector3(transform.position.x, 0, 12), Quaternion.identity);
        }
        if(aleatorio == 2)
        {
            Instantiate(plataforma2, new  Vector3(transform.position.x, 0, 12), Quaternion.identity);
        }
        if(aleatorio == 3)
        {
            Instantiate(plataforma3, new  Vector3(transform.position.x, 0, 12), Quaternion.identity);
        }
        if(aleatorio == 4)
        {
            Instantiate(plataforma4, new  Vector3(transform.position.x, 0, 12), Quaternion.identity);
        }
        if(aleatorio == 5)
        {
            Instantiate(plataforma5, new  Vector3(transform.position.x, 0, 12), Quaternion.identity);
        }

        aleatorio = Random.Range(1, 6);
        if(aleatorio == 1)
        {
            Instantiate(plataforma1, new  Vector3(transform.position.x, 0, 24), Quaternion.identity);
        }
        if(aleatorio == 2)
        {
            Instantiate(plataforma2, new  Vector3(transform.position.x, 0, 24), Quaternion.identity);
        }
        if(aleatorio == 3)
        {
            Instantiate(plataforma3, new  Vector3(transform.position.x, 0, 24), Quaternion.identity);
        }
        if(aleatorio == 4)
        {
            Instantiate(plataforma4, new  Vector3(transform.position.x, 0, 24), Quaternion.identity);
        }
        if(aleatorio == 5)
        {
            Instantiate(plataforma5, new  Vector3(transform.position.x, 0, 24), Quaternion.identity);
        }
        
        aleatorio = Random.Range(1, 6);
        if(aleatorio == 1)
        {
            Instantiate(plataforma1, new  Vector3(transform.position.x, 0, 36), Quaternion.identity);
        }
        if(aleatorio == 2)
        {
            Instantiate(plataforma2, new  Vector3(transform.position.x, 0, 36), Quaternion.identity);
        }
        if(aleatorio == 3)
        {
            Instantiate(plataforma3, new  Vector3(transform.position.x, 0, 36), Quaternion.identity);
        }
        if(aleatorio == 4)
        {
            Instantiate(plataforma4, new  Vector3(transform.position.x, 0, 36), Quaternion.identity);
        }
        if(aleatorio == 5)
        {
            Instantiate(plataforma5, new  Vector3(transform.position.x, 0, 36), Quaternion.identity);
        }

        aleatorio = Random.Range(1, 6);
        if(aleatorio == 1)
        {
            Instantiate(plataforma1, new  Vector3(transform.position.x, 0, 48), Quaternion.identity);
        }
        if(aleatorio == 2)
        {
            Instantiate(plataforma2, new  Vector3(transform.position.x, 0, 48), Quaternion.identity);
        }
        if(aleatorio == 3)
        {
            Instantiate(plataforma3, new  Vector3(transform.position.x, 0, 48), Quaternion.identity);
        }
        if(aleatorio == 4)
        {
            Instantiate(plataforma4, new  Vector3(transform.position.x, 0, 48), Quaternion.identity);
        }
        if(aleatorio == 5)
        {
            Instantiate(plataforma5, new  Vector3(transform.position.x, 0, 48), Quaternion.identity);
        }
    }
}
