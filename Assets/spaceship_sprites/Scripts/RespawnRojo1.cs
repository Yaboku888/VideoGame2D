using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnRojo1 : MonoBehaviour
{
    public float time = 0;
    public Transform canon;
    public GameObject naveRoja1;
    private float movement;
 

    void Update()
    {
        time = time + Time.deltaTime;
        if (time >=2)
        {
            GameObject go = Instantiate(naveRoja1, canon.transform.position, canon.transform.rotation);
            Destroy(go, 20f);
            time = 0;
        }   
    
    }
}
