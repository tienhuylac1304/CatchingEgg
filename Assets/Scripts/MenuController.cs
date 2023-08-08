using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button btnPlay;
    public Button btnSetting;
    public Button btnExit;
    public GameObject pnlSetting;
    // Start is called before the first frame update
    void Start()
    {
        SetOnclick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Play()
    {
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
    }
    void Setting()
    {
        pnlSetting.SetActive(true);
    }
    void Exit()
    {
        Application.Quit();
    }
    void SetOnclick()
    {
        btnExit.onClick.AddListener(Exit);
        btnSetting.onClick.AddListener(Setting);
        btnPlay.onClick.AddListener(Play);
    }
}
