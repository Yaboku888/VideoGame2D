using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavePilaVida : MonoBehaviour
{
    public float speedmovement;
    public Vector2 movimiento;
    public float vidamax = 2;
    public float vidaActual;

    void Start()
    {
        vidaActual = vidamax;

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
        float da�o = 1;
        vidaActual = vidaActual - da�o;
        if (vidaActual == 0)
        {
            gameObject.SetActive(false);
        }
        
    }

}
