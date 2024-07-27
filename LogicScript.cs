using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText; // reference to the text gameobject
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]

    public void addScore(int scoreToAdd) // increments the player score
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString(); // changing the text on the UI to obtain this new val

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
    }
    
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
