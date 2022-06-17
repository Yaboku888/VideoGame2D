using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveRoja1 : MonoBehaviour
{
    public Movimiento Movement;
    public Transform Jugador;
    public float rango = 60;
    private float distance;
    public float time = 0;
    // Start is called before the first frame update
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
            Movement.Move(-1, -1);
        }
        if (time >= 3)
        {
            Movement.Move(-0, -1);
        }
        if (time >= 4)
        {
            Movement.Move(-1, 0);
            time = 0;
        }
    }
}
