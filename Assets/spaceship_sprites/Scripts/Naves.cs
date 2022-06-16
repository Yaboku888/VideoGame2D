using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Naves : MonoBehaviour
{
    public Movimiento Movement;
    public Transform Jugador;
    public float rango = 60;
    private float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, Jugador.position);
        Movement.Move(-1, 0);
    }
}
