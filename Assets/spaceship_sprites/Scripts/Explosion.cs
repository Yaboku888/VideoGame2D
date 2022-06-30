using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject nave;
    public GameObject explotion;
    void Start()
    {
        explotion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        nave.GetComponent<SpriteRenderer>().enabled = false;
        explotion.SetActive(true);
        Destroy(explotion, 1f);
    }


}

