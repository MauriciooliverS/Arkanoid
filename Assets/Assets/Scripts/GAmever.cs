using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


public class GAmever : MonoBehaviour
{
   public GameObject GameOver;
   public Bola bolinha;
    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoPontos2;
    public TextMeshProUGUI textoPontos3;
    public TextMeshProUGUI textoPontos4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        GameOver.SetActive(false);  
         AtualizarTexto();        
    }
    void Update()
    {
         AtualizarTexto(); 
    }
    public void VivePlayer()
    {
        GameOver.SetActive(false); 
        SceneManager.LoadScene("Fase1");
        Time.timeScale = 1;    
    }

    // Update is called once per frame
    public void MorrePlayer()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void VoltaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    void AtualizarTexto()
    {
        // Concatenando a variável com a string
         textoPontos.text = bolinha.pontos.ToString() + " Pontos" ;
         textoPontos2.text = bolinha.pontos.ToString() + " Pontos" ;
         textoPontos3.text = bolinha.pontos.ToString() + " Pontos" ;
         textoPontos4.text = bolinha.pontos.ToString() + " Pontos" ;
    }
}
