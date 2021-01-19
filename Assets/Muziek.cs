using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Muziek : MonoBehaviour
{

    private static Muziek instance = null;

    public static Muziek Instance

    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            if (instance.GetComponent<AudioSource>().clip != GetComponent<AudioSource>().clip)
            {
                instance.GetComponent<AudioSource>().clip = GetComponent<AudioSource>().clip;
                instance.GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume;
                instance.GetComponent<AudioSource>().Play();
            }

            
            
            Destroy(this.gameObject);
            return;
        }

        {
            instance = this;
            GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if(currentScene.name == "Eindmap")
        {
            Destroy(this.gameObject);
            return;
        }
    }
}
