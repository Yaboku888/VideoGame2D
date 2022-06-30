using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRaro : MonoBehaviour
{
    public float time = 0;
    public GameObject naveRara;
    private float movement;
    Vector3 position;
    float numero;

    void Update()
    {
        numero = Random.Range(-12f, 12f);
        time = time + Time.deltaTime;
        if (time >= 2)
        {
            position = transform.position;
            position.x = numero;
            GameObject go = Instantiate(naveRara, position, transform.rotation);
            Destroy(go, 5f);
            time = 0;
        }

    }
}