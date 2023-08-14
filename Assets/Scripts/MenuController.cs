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
    public GameObject audioController;
    // Start is called before the first frame update
    void Start()
    {
        audioController.GetComponent<AudioController>().GetThemeMusic();
        SetOnclick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Play()
    {

        audioController.GetComponent<AudioController>().GetClickSound();
        audioController.GetComponent<AudioController>().StopThemeMusic();
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
    }
    void Setting()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        pnlSetting.SetActive(true);
    }
    void Exit()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        Application.Quit();
    }
    void SetOnclick()
    {
        btnExit.onClick.AddListener(Exit);
        btnSetting.onClick.AddListener(Setting);
        btnPlay.onClick.AddListener(Play);
    }
}
