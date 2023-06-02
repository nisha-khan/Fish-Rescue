using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel; 
    public bool isGameOver =false;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")== null)
        {
            gameOverPanel.SetActive(true);
            isGameOver = true;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
