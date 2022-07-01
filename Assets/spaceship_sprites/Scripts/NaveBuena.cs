using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveBuena : MonoBehaviour
{
    public Movimiento Movement;
    public Transform Jugador;
    public float rango = 60;
    private float distance;
    public float time = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, Jugador.position);
        Movement.Move(-1, 0);

        time = time + Time.deltaTime;
        if (time >= 2)
        {
            Movement.Move(-1, 0);
        }
        if (time >= 3)
        {
            Movement.Move(-1, 0);
        }
        if (time >= 4)
        {
            Movement.Move(1, 0);
            time = 0;
        }
    }
}
