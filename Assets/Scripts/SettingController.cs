using UnityEngine;
using UnityEngine.UI;

public class SettingController : MonoBehaviour
{
    private bool isMute;
    private bool isUnsound;
    public Button btnAccept;
    public Button btnCancel;
    public Button btnMusic;
    public Button btnSound;
    public Sprite imgMute;
    public Sprite imgMusic;
    public Sprite imgSound;
    public Sprite imgUnsound;
    public Text txtMusicState;
    public Text txtSoundState;
    public GameObject audioController;

    // Start is called before the first frame update
    void Start()
    {
        SetStateForIsMute();
        SetStateForIsUnsound();
        SetOnclick();
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
    void SetStateForIsUnsound()
    {
        if (PlayerPrefs.GetString("isUnsound").Equals("True"))
        {
            isUnsound = true;
            txtSoundState.text = "Mute";
            btnSound.GetComponent<Image>().sprite = imgUnsound;
        }
        else
        {
            isUnsound = false;
            txtSoundState.text = "Sound";
            btnSound.GetComponent<Image>().sprite = imgSound;
        }
    }
    void SetOnclick()
    {
        btnAccept.onClick.AddListener(Accept);
        btnCancel.onClick.AddListener(Cancel);
        btnMusic.onClick.AddListener(SettingMusic);
        btnSound.onClick.AddListener(SettingSound);
    }
    void SettingMusic()
    {
        audioController.GetComponent<AudioController>().SetTempSound(isUnsound);
        isMute =!isMute;
        if(isMute)
        {
            btnMusic.GetComponent<Image>().sprite = imgMute;
            txtMusicState.text = "Mute";
            audioController.GetComponent<AudioController>().SetTempMusic(isMute);
        }
        else
        {
            btnMusic.GetComponent<Image>().sprite = imgMusic;
            txtMusicState.text = "Music";
            audioController.GetComponent<AudioController>().SetTempMusic(isMute);
        }
    }
    void SettingSound()
    {

        isUnsound=!isUnsound;
        if(isUnsound)
        {
            btnSound.GetComponent<Image>().sprite = imgUnsound;
            txtSoundState.text = "Mute";
            audioController.GetComponent<AudioController>().SetTempSound(isUnsound);
        }
        else
        {
            btnSound.GetComponent<Image>().sprite = imgSound;
            txtSoundState.text = "Sound";
            audioController.GetComponent<AudioController>().SetTempSound(isUnsound);
        }
    }
    void Accept()
    {
        PlayerPrefs.SetString("isMute",isMute.ToString());
        PlayerPrefs.SetString("isUnsound", isUnsound.ToString());
        audioController.GetComponent<AudioController>().SetAudio();
        gameObject.SetActive(false);
    }
    void Cancel()
    {
        SetStateForIsMute();
        SetStateForIsUnsound();
        audioController.GetComponent<AudioController>().SetAudio();
        gameObject.SetActive(false);
    }
    public bool GetIsMute()
    {
        return isMute;
    }   
    public bool GetIsunsound()
    {
        return isUnsound;
    }
}
