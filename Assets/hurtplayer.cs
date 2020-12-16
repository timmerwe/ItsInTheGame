using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtplayer : MonoBehaviour
{
    public int damagetogive;
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
        if (other.gameObject.name == "BURLY-MAN_1_swordsman")
        {
            other.gameObject.GetComponent<health>().hurtplayer(damagetogive);
        }
    }
}
