using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPila : MonoBehaviour
{
    public float time = 0;
    public GameObject navePila;
    private float movement;
    Vector3 position;
    float numero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numero = Random.Range(-12f, 12f);
        time = time + Time.deltaTime;
        if (time >= 10)
        {
            position = transform.position;
            position.x = numero;
            GameObject go = Instantiate(navePila, position, transform.rotation);
            Destroy(go, 20f);
            time = 0;
        }

    }
}
