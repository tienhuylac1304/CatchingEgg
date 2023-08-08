using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int heal=2;
    private int score;
    private bool isEndGame;
    public GameObject gamePlayUiController;
    public GameObject gameOverController;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        isEndGame = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BrokeEgg()
    {
        gamePlayUiController.GetComponent<GamePlayUiController>().LostHeal(heal);
        if (heal >0)
        {
            heal--;
        }
        else
            EndGame();
    }
    public void EndGame()
    {
        isEndGame=true;
        Time.timeScale = 0;
        if (PlayerPrefs.GetInt("best_score") <= score)
        {
            PlayerPrefs.SetInt("best_score", score);
        }
        gameOverController.GetComponent<GameOverController>().ShowPanel(score);
    }
    public void AddScore()
    {
        score++;
        gamePlayUiController.GetComponent<GamePlayUiController>().ShowScore(score);
    }
    public bool GetIsEndGame()
    {
        return isEndGame;
    }
    public void Restart() 
    {
        SceneManager.LoadScene(0);
    }

}
