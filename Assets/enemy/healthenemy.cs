using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthenemy : MonoBehaviour
{

    public int enemyMaxHealth;
    public int enemycurrenthealth;


    void Start()
    {
        enemycurrenthealth = enemyMaxHealth;
    }


    void Update()
    {
        if (enemycurrenthealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void hurtenemy(int damagetogive1)
    {
        enemycurrenthealth -= damagetogive1;
    }

    public void setmaxhealth()
    {
        enemycurrenthealth = enemyMaxHealth;
    }

}
