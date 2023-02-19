using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaInicial : MonoBehaviour
{
    public Text dinheiroTxt;
    public GameObject lojaPanel;
    bool lojaAberta = false;

    // Start is called before the first frame update
    void Start()
    {
        dinheiroTxt.text = "$: " + PlayerPrefs.GetInt("totalScore").ToString();
        lojaPanel.SetActive(false);
        lojaPanel.GetComponent<Loja>().AtualizarTexturas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Sair()
    {   
        Application.Quit();
    }

    public void Loja()
    {   
        dinheiroTxt.text = "$: " + PlayerPrefs.GetInt("totalScore").ToString();
        lojaPanel.SetActive(!lojaAberta);
        lojaAberta = !lojaAberta;
    }
}
