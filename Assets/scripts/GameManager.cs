using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;
    public bool gameOver;
    public GameObject gameOverpanel;


    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives : " + lives;
        scoreText.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }

        livesText.text = "Lives : " + lives;

    }

    public void UpdateScore(int points)
    {
        score += points;

        scoreText.text = "Score: " + score;
    }

    void GameOver()
    {
        gameOver = true;
        gameOverpanel.SetActive (true);
    }

    public void PlayAgain()
    {
        //SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
