using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameIsOver;
    public GameObject gameUI;
    public GameObject gameOverUI;

    void Start()
    {
        gameIsOver = false;
    }
   // Update is called once per frame
    void Update()
    {
        if (gameIsOver)
            return;

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameIsOver = true;
        gameUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}
