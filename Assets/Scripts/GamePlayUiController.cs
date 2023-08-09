using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUiController : MonoBehaviour
{
    public Button btnPause;
    public Text txtScore;
    public List<Image> heals;
    public GameObject pnlPause;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        pnlPause.SetActive(false);
        btnPause.onClick.AddListener(Pause);
    }

    private void Pause()
    {
        if (!gameController.GetComponent<GameController>().GetIsEndGame())
        {
            Time.timeScale = 0;
            pnlPause.SetActive(true);
        }
    }
    public void ShowScore(int score)
    {
        txtScore.GetComponent<Text>().text = "Best Score: " + PlayerPrefs.GetInt("best_score").ToString()+"\nScore: " + score.ToString();
    }
    public void LostHeal(int index)
    {
        heals[index].gameObject.SetActive(false);
    }
}
