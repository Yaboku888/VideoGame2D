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
        gameObject.SetActive(false);
    }

}

