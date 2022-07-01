using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int vidaMaxima = 3;
    public int vidaActual;
   
    // public float vida;
    // public GameObject  [] vidass;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
  


    void Start()
    {
        vidaActual = vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        /* if (vidaActual < 4)
        {
            Destroy(vidass[0]);

        }*/

         //vidam--;
        
    }

    public void OnTriggerEnter(Collider other)
    {

        
        if (other.tag =="enemigos")
        {
            print("afasfasfasf");
            vidaActual = vidaActual - 1;

        }
        if (vidaActual == 2)
        {
            vida1.gameObject.SetActive(false);
        }
        if (vidaActual == 1)
        {
            vida2.gameObject.SetActive(false);
        }
        if (vidaActual == 0)
        {
            vida3.gameObject.SetActive(false);
            SceneManager.LoadScene("perdio");
        }


    }
    


}
