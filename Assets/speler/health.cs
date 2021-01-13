using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour{

    public int playerMaxHealth;
    public int playercurrenthealth;

 
    void Start()
    {
        playercurrenthealth = playerMaxHealth; 
    }

    
    void Update()
    {
        if(playercurrenthealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void hurtplayer(int damagetogive)
    {
        playercurrenthealth -= damagetogive;
    }

    public void setmaxhealth()
    {
        playercurrenthealth = playerMaxHealth;
    }
}
