using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public static bool isPlayerDead = false;
    private Text win;

    void Start()
    {
        win = GetComponent<Text>();
        win.enabled = false;
    }

    void Update()
    {
        if (isPlayerDead)
        {
            win.enabled = true;


       //     Invoke("LoadNextScene", 1.0f);
       }
    }

    // Fun��o para carregar outra cena
   // void LoadNextScene()
   // {
       // SceneManager.LoadScene("winscene");
   // }
}
