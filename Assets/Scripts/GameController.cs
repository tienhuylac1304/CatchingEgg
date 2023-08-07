using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int brokeEgg;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        brokeEgg = 0;
        score = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BrokeEgg()
    {
        if(brokeEgg <2)
        {
            brokeEgg++;
        }
        else
            EndGame();
    }
    public void EndGame()
    {
        Time.timeScale = 0;
    }
    public void AddScore()
    {
        score++;
        Debug.Log(score);
    }
    public void Restart() 
    {
        SceneManager.LoadScene(0);
    }
}
