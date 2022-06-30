using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavePilaVida : MonoBehaviour
{
    public float speedmovement;
    public Vector2 movimiento;
    public float vidamax = 2;
    public float vidaActual;
    public GameObject nave;
    public GameObject explotion;
    void Start()
    {
        vidaActual = vidamax;
        explotion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Move(float vertical, float Horizontal)
    {
        movimiento.x = Horizontal;
        movimiento.y = vertical;

        movimiento = transform.TransformDirection(movimiento);
        transform.Translate(movimiento * Time.deltaTime * speedmovement);
    }
    private void OnMouseDown()
    {
       
        float daño = 1;
        vidaActual = vidaActual - daño;
       
       
        if (vidaActual == 0)
        { 
            speedmovement = 0;
            nave.GetComponent<SpriteRenderer>().enabled = false;
            explotion.SetActive(true);
            Destroy(explotion, 1f);
        }
        
    }

}
