using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    public GameObject player;
    public Color laranja;
    public Text txt0, txt1, txt2, txt3, txt4, txt5, txt6, txt7;

    // Start is called before the first frame update
    void Start()
    {
        AtualizarTexturas();
        AtualizarTextos();

        if(PlayerPrefs.GetString("produtosComprados") == "")
        {
            PlayerPrefs.SetString("produtosComprados", "_0_");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") + 10000);
        }
    }

    public void Produto(int numero)
    {
        if(numero == 0)
        {
            PlayerPrefs.SetInt("texturaUsando", 0);
            AtualizarTexturas();
            AtualizarTextos();
            txt0.text = "Usando";
        }
        if(numero == 1)
        {
            if(PlayerPrefs.GetString("produtosComprados").Contains("_1_"))
            {
                PlayerPrefs.SetInt("texturaUsando", 1);
                AtualizarTexturas();
                AtualizarTextos();
                txt1.text = "Usando";
            }
            else if(PlayerPrefs.GetInt("totalScore") >= 200)
            {
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") - 200);
                PlayerPrefs.SetString("produtosComprados", PlayerPrefs.GetString("produtosComprados") + "_1_");
                AtualizarTextos();
            }
        }
        if(numero == 2)
        {
            if(PlayerPrefs.GetString("produtosComprados").Contains("_2_"))
            {
                PlayerPrefs.SetInt("texturaUsando", 2);
                AtualizarTexturas();
                AtualizarTextos();
                txt2.text = "Usando";
            }
            else if(PlayerPrefs.GetInt("totalScore") >= 400)
            {
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") - 400);
                PlayerPrefs.SetString("produtosComprados", PlayerPrefs.GetString("produtosComprados") + "_2_");
                AtualizarTextos();
            }
        }
        if(numero == 3)
        {
            if(PlayerPrefs.GetString("produtosComprados").Contains("_3_"))
            {
                PlayerPrefs.SetInt("texturaUsando", 3);
                AtualizarTexturas();
                AtualizarTextos();
                txt3.text = "Usando";
            }
            else if(PlayerPrefs.GetInt("totalScore") >= 600)
            {
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") - 600);
                PlayerPrefs.SetString("produtosComprados", PlayerPrefs.GetString("produtosComprados") + "_3_");
                AtualizarTextos();
            }
        }
        if(numero == 4)
        {
            if(PlayerPrefs.GetString("produtosComprados").Contains("_4_"))
            {
                PlayerPrefs.SetInt("texturaUsando", 4);
                AtualizarTexturas();
                AtualizarTextos();
                txt4.text = "Usando";
            }
            else if(PlayerPrefs.GetInt("totalScore") >= 800)
            {
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") - 800);
                PlayerPrefs.SetString("produtosComprados", PlayerPrefs.GetString("produtosComprados") + "_4_");
                AtualizarTextos();
            }
        }
        if(numero == 5)
        {
            if(PlayerPrefs.GetString("produtosComprados").Contains("_5_"))
            {
                PlayerPrefs.SetInt("texturaUsando", 5);
                AtualizarTexturas();
                AtualizarTextos();
                txt5.text = "Usando";
            }
            else if(PlayerPrefs.GetInt("totalScore") >= 1000)
            {
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") - 1000);
                PlayerPrefs.SetString("produtosComprados", PlayerPrefs.GetString("produtosComprados") + "_5_");
                AtualizarTextos();
            }
        }
        if(numero == 6)
        {
            if(PlayerPrefs.GetString("produtosComprados").Contains("_6_"))
            {
                PlayerPrefs.SetInt("texturaUsando", 6);
                AtualizarTexturas();
                AtualizarTextos();
                txt6.text = "Usando";
            }
            else if(PlayerPrefs.GetInt("totalScore") >= 1200)
            {
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") - 1200);
                PlayerPrefs.SetString("produtosComprados", PlayerPrefs.GetString("produtosComprados") + "_6_");
                AtualizarTextos();
            }
        }
        if(numero == 7)
        {
            if(PlayerPrefs.GetString("produtosComprados").Contains("_7_"))
            {
                PlayerPrefs.SetInt("texturaUsando", 7);
                AtualizarTexturas();
                AtualizarTextos();
                txt7.text = "Usando";
            }
            else if(PlayerPrefs.GetInt("totalScore") >= 2000)
            {
                PlayerPrefs.SetInt("totalScore", PlayerPrefs.GetInt("totalScore") - 2000);
                PlayerPrefs.SetString("produtosComprados", PlayerPrefs.GetString("produtosComprados") + "_7_");
                AtualizarTextos();
            }
        }
        
    }

    public void AtualizarTexturas()
    {
        if(PlayerPrefs.GetInt("texturaUsando") == 0)
        {
            player.GetComponent<Renderer>().material.color = Color.white;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 1)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 2)
        {
            player.GetComponent<Renderer>().material.color = Color.blue;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 3)
        {
            player.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 4)
        {
            player.GetComponent<Renderer>().material.color = laranja;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 5)
        {
            player.GetComponent<Renderer>().material.color = Color.green;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 6)
        {
            player.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 7)
        {
            player.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    void AtualizarTextos()
    {
        txt0.text = "Adquirido";
        if(PlayerPrefs.GetString("produtosComprados").Contains("_1_"))
        {
            txt1.text = "Adquirido";
        }else
        {
            txt1.text = "À venda";
        }
        if(PlayerPrefs.GetString("produtosComprados").Contains("_2_"))
        {
            txt2.text = "Adquirido";
        }else
        {
            txt2.text = "À venda";
        }
        if(PlayerPrefs.GetString("produtosComprados").Contains("_3_"))
        {
            txt3.text = "Adquirido";
        }else
        {
            txt3.text = "À venda";
        }
        if(PlayerPrefs.GetString("produtosComprados").Contains("_4_"))
        {
            txt4.text = "Adquirido";
        }else
        {
            txt4.text = "À venda";
        }
        if(PlayerPrefs.GetString("produtosComprados").Contains("_5_"))
        {
            txt5.text = "Adquirido";
        }else
        {
            txt5.text = "À venda";
        }
        if(PlayerPrefs.GetString("produtosComprados").Contains("_6_"))
        {
            txt6.text = "Adquirido";
        }else
        {
            txt6.text = "À venda";
        }
        if(PlayerPrefs.GetString("produtosComprados").Contains("_7_"))
        {
            txt7.text = "Adquirido";
        }else
        {
            txt7.text = "À venda";
        }

        if(PlayerPrefs.GetInt("texturaUsando") == 0)
        {
            txt0.text = "Usando";
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 1)
        {
            txt1.text = "Usando";
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 2)
        {
            txt2.text = "Usando";
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 3)
        {
            txt3.text = "Usando";
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 4)
        {
            txt4.text = "Usando";
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 5)
        {
            txt5.text = "Usando";
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 6)
        {
            txt6.text = "Usando";
        }
        if(PlayerPrefs.GetInt("texturaUsando") == 7)
        {
            txt7.text = "Usando";
        }
    }
}
