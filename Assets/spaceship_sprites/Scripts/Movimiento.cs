using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speedmovement;
    public Vector2 movimiento;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Move(-1f,0);
    }
    public void Move (float vertical, float Horizontal)
    {
        movimiento.x = Horizontal;
        movimiento.y = vertical;

        movimiento = transform.TransformDirection(movimiento);
        transform.Translate(movimiento * Time.deltaTime * speedmovement);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject, 0f);

        speedmovement = 0;
    }

}

