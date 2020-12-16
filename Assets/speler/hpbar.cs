using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpbar : MonoBehaviour
{
    public Slider healthbar;
    public health healthmanager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.maxValue = healthmanager.playerMaxHealth;
        healthbar.value = healthmanager.playercurrenthealth;
    }
}
