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
    public Button btnSound;
    private bool isMute;
    private bool isUnsound;
    public Sprite imgMute;
    public Sprite imgMusic;
    public Sprite imgSound;
    public Sprite imgUnsound;
    public GameObject audioController;

    // Start is called before the first frame update
    void Start()
    {
        SetStateForMusicButton();
        SetStateForSoundButton();
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
        btnSound.onClick.AddListener(SettingSound);
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
        audioController.GetComponent<AudioController>().SetTempMusic(isMute);
    } 
    private void SettingSound()
    {
        isUnsound = !isUnsound;
        if (isUnsound)
        {
            btnSound.GetComponent<Image>().sprite = imgUnsound;
        }
        else
        {
            btnSound.GetComponent<Image>().sprite = imgSound;
        }
        audioController.GetComponent<AudioController>().SetTempSound(isUnsound);
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
    private void SetStateForSoundButton()
    {
        if (PlayerPrefs.GetString("isUnsound").Equals("True"))
        {
            isUnsound = true;
            btnSound.GetComponent<Image>().sprite = imgUnsound;
        }
        else
        {
            isUnsound = false;
            btnSound.GetComponent<Image>().sprite = imgSound;
        }
    }

    private void Resume()
    {
        PlayerPrefs.SetString("isMute", isMute.ToString());
        PlayerPrefs.SetString("isUnsound", isUnsound.ToString());
        audioController.GetComponent<AudioController>().SetAudio();
        audioController.GetComponent<AudioController>().GetClickSound();
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    private void GoToMenu()
    {

        PlayerPrefs.SetString("isMute", isMute.ToString());
        PlayerPrefs.SetString("isUnsound", isUnsound.ToString());
        audioController.GetComponent<AudioController>().SetAudio();
        audioController.GetComponent<AudioController>().GetClickSound();
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);
    }
}
