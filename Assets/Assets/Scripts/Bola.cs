using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool estaVivo = true;
    public int pontos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag("Morte"))
        {
            Time.timeScale = 0;
        }
        if(collision.gameObject.CompareTag("Bases"))
        {
             Destroy(collision.gameObject);
            pontos ++;
        }
    }
}

    