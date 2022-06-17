using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnGris1 : MonoBehaviour
{
    public float time = 0;
    public Transform canon;
    public GameObject naveGris1;
    private float movement;

    void Start()
    {
        
    }

    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 2)
        {
            GameObject go = Instantiate(naveGris1, canon.transform.position, canon.transform.rotation);
            Destroy(go, 20f);
            time = 0;
        }
    }
}
