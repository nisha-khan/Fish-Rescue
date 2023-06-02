using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    private float score;


    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();

        }
         if(score > PlayerPrefs.GetFloat("HighScore", 0))
        {
              PlayerPrefs.SetFloat("HighScore",((int)score));
        }
        
     }   

     void Start()
     {
        updatehighscore();
     }   

      void sethighscore()
     {
        // if(score > PlayerPrefs.GetFloat("HighScore", 0))
        //{
          //    PlayerPrefs.SetFloat("HighScore",score);
        //}

       // highScoreText.text = PlayerPrefs.GetFloat("HighScore", 0). ToString();
     }

     void updatehighscore()
     {
        highScoreText.text = $"BEST : {PlayerPrefs.GetFloat("HighScore", 0)}";
     }
    
}
