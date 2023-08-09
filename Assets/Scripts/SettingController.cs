using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingController : MonoBehaviour
{
    private bool isMute;
    public Button btnAccept;
    public Button btnCancel;
    public Button btnMusic;
    public Sprite imgMute;
    public Sprite imgMusic;
    public Text txtMusicState;

    // Start is called before the first frame update
    void Start()
    {
        SetStateForIsMute();
        SetOnclick();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SetStateForIsMute()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            isMute = true;
            txtMusicState.text = "Mute";
            btnMusic.GetComponent<Image>().sprite = imgMute;
        }
        else
        {
            isMute = false;
            txtMusicState.text = "Muisc";
            btnMusic.GetComponent<Image>().sprite = imgMusic;
        }
    }
    void SetOnclick()
    {
        btnAccept.onClick.AddListener(Accept);
        btnCancel.onClick.AddListener(Cancel);
        btnMusic.onClick.AddListener(SettingMusic);
    }
    void SettingMusic()
    {
        isMute=!isMute;
        if(isMute)
        {
            btnMusic.GetComponent<Image>().sprite = imgMute;
            txtMusicState.text = "Mute";
        }
        else
        {
            btnMusic.GetComponent<Image>().sprite = imgMusic;
            txtMusicState.text = "Music";
        }
    }
    void Accept()
    {
        PlayerPrefs.SetString("isMute",isMute.ToString());

        gameObject.SetActive(false);
    }
    void Cancel()
    {
        SetStateForIsMute();
        gameObject.SetActive(false);
    }
    public bool GetIsMute()
    {
        return isMute;
    }
}
