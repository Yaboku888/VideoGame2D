using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float time = 0;
    public Transform canon;
    public GameObject murcielago;
    private float movement;
 

    void Update()
    {
        time = time + Time.deltaTime;
        if (time >=2)
        {
            GameObject go = Instantiate(murcielago, canon.transform.position, canon.transform.rotation);
            Destroy(go, 20f);
            time = -7;
        }   
    
    }
}
