using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameControllerLeikur : MonoBehaviour
{
    public static GameControllerLeikur Instance;

    public TextMeshProUGUI scoreText;

    private int score = 0;

    private int coinsToCollect = 7;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScore();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScore();

        if (score >= coinsToCollect)
        {
            LoadNextScene();
        }
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    private void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
