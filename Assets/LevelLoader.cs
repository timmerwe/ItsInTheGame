﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{

    private bool playerInZone;

    public string levelToLoad;


    // Start is called before the first frame update
    void Start() {
        playerInZone = false;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && playerInZone)
        {
            Application.LoadLevel(levelToLoad);
        }
    }

    void onTriggerEnter2D(Collider2D other)
    {
        if(other.name == "BURLY-MAN_1_swordsman")
        {
            playerInZone = true;
        }

    }


}
