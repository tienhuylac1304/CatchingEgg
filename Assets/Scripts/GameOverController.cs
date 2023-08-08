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
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        obj.SetActive(false);
        SetOnclick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPanel(int score)
    {
        obj.SetActive(true);
        txtScore.text ="Your Score: "+ score.ToString() +"\nBest Score: "+ PlayerPrefs.GetInt("best_score").ToString();
    }
    void Quit()
    {
        Application.Quit();
    }
    void Restart()
    {
        obj.SetActive(false);
        SceneManager.LoadScene(1);
    }
    void GoToMenu()
    {
        obj.SetActive(false);
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
