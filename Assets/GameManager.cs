using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public GameObject restartButton;

    int score = 0;
    bool isGameOver = false;

    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);

        scoreText.text = "Score: 0";
    }

    public void AddScore()
    {
        if (!isGameOver)
        {
            score++;
            scoreText.text = "Score: " + score;
        }
    }
    public int GetDifficultyLevel()
    {
        return score / 10;
    }

    public void GameOver()
    {
        isGameOver = true;

        gameOverText.SetActive(true);
        restartButton.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}