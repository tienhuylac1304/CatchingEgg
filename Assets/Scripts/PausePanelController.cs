using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausePanelController : MonoBehaviour
{
    public Button btnResume;
    public Button btnMenu;
    public Button btnMusic;
    private bool isMute;
    public Sprite imgMute;
    public Sprite imgMusic;
    // Start is called before the first frame update
    void Start()
    {
        SetStateForMusicButton();
        SetOnclick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetOnclick()
    {
        btnMenu.onClick.AddListener(GoToMenu);
        btnResume.onClick.AddListener(Resume);
        btnMusic.onClick.AddListener(SettingMusic);
    }

    private void SettingMusic()
    {
        isMute = !isMute;
        if (isMute)
        {
            btnMusic.GetComponent<Image>().sprite = imgMute;
        }
        else
        {
            btnMusic.GetComponent<Image>().sprite = imgMusic;
        }
    }
    private void SetStateForMusicButton()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            isMute = true;
            btnMusic.GetComponent<Image>().sprite = imgMute;
        }
        else
        {
            isMute = false;
            btnMusic.GetComponent<Image>().sprite = imgMusic;
        }
    }

    private void Resume()
    {
        PlayerPrefs.SetString("isMute", isMute.ToString());
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    private void GoToMenu()
    {
        //test
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);
    }
}
