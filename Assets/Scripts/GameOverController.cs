using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    GameObject obj;
    public Text txtScore;
    public Button btnRestart;
    public Button btnMenu;
    public Button btnQuit;
    public GameObject audioController;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        obj.SetActive(false);
        SetOnclick();
    }

    public void ShowPanel(int score)
    {
        obj.SetActive(true);
        txtScore.text ="Your Score: "+ score.ToString() +"\nBest Score: "+ PlayerPrefs.GetInt("best_score").ToString();
    }
    void Quit()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        Application.Quit();
    }
    void Restart()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        obj.SetActive(false);
        SceneManager.LoadScene(1);
    }
    void GoToMenu()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);
    }
    void SetOnclick()
    {
        btnRestart.onClick.AddListener(Restart);
        btnMenu.onClick.AddListener(GoToMenu);
        btnQuit.onClick.AddListener(Quit);
    }
}
