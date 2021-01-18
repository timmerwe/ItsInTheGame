using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtboss : MonoBehaviour
{
    public int damagetogive1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "MonD_01")
        {
            other.gameObject.GetComponent<healthenemy>().hurtenemy(damagetogive1);
        }
    }
}
