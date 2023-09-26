using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerScore.playerScore = 0;
            GameOver.isPlayerDead = false;
            Win.isPlayerDead = false;
            Time.timeScale = 1;

            SceneManager.LoadScene("cena1");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerScore.playerScore = 0;
            Win.isPlayerDead = false;
            Time.timeScale = 1;

            SceneManager.LoadScene("Menu");
        }

    }
}
