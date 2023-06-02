using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgdMusic;

    void Awake()
    {
        if(backgdMusic == null)
        {
            backgdMusic = this;
            DontDestroyOnLoad(backgdMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
