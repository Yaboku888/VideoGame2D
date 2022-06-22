using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrullaje : MonoBehaviour
{
    //velocidad del objeto nave, animal etc...
    [SerializeField] private float velocidadmovimiento;

    //puntos de movimientos donde se dirigira el objeto
    [SerializeField] private Transform[] puntosmovimientos;

    //para que llegue no al punto sino a una distancia un poquito mas alejada
    [SerializeField] private float distanciaminima;

    //para controlar donde se va a mover
    private int siguientePaso = 0;

    // funciona para ver como se verá nuestro personaje
    public SpriteRenderer spriteRenderer;


    private void start()
    {
        siguientePaso = Random.Range(0, puntosmovimientos.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosmovimientos[siguientePaso].position, velocidadmovimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, puntosmovimientos[siguientePaso].position) < distanciaminima)
        {
            siguientePaso += 1;
            if(siguientePaso >= puntosmovimientos.Length)
            {
                siguientePaso = 0;
            }
        }   Girar();
    
    }

    private void Girar()
    {
        if (transform.position.x < puntosmovimientos[siguientePaso].position.x)
        {
            spriteRenderer.flipX = true;
        } 
        else
        {
            spriteRenderer.flipX = false; 
        }
    }
}