using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource themeSong;
    public AudioSource click;
    public AudioSource broke;
    public AudioSource point;
    public AudioSource game_over;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void SetAudio()
    {
        //Music
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            themeSong.mute = true;
            game_over.mute = true;
        }
        else
        {
            themeSong.mute=false;
            themeSong.Play();
            game_over.mute=false;
        }
        //Sound
        if (PlayerPrefs.GetString("isUnsound").Equals("True"))
        {
            click.mute = true;
            point.mute = true;
            broke.mute = true;
        }
        else
        {
            click.mute = false;
            click.Play();
            point.mute = false;
            broke.mute = false;
        }
    }
    public void SetTempMusic(bool isMute)
    {
        //Music
        if (isMute)
        {
            themeSong.mute=true;
        }
        else
        {
            themeSong.mute=false;
            themeSong.Play();
        }
       
    }
    public void SetTempSound(bool isUnsound)
    {
        //Sound
        if (isUnsound)
        {
            click.mute = true;
        }
        else
        {
            click.mute = false;
            click.Play();
        }
    }
    public void GetThemeMusic()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            themeSong.mute=true;
        }
        else
        {
            themeSong.Play();
        }
    }
    public void GetGameOverMusic()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            game_over.mute = true;
        }
        else
        {
            game_over.Play();
        }
    }
    public void GetClickSound()
    {
        if (PlayerPrefs.GetString("isUnsound").Equals("True"))
        {
            click.mute=true;
        }
        else
        {
            click.Play();
        }
    }
    public void GetBrokeSound()
    {
        if (PlayerPrefs.GetString("isUnsound").Equals("True"))
        {
            broke.mute=true;
        }
        else
        {
            broke.Play();
        }
    }
    public void GetPointSound()
    {
        if (PlayerPrefs.GetString("isUnsound").Equals("True"))
        {
            point.mute=true;
        }
        else
        {
            point.Play();
        }
    }
    public void StopThemeMusic()
    {
        themeSong.Stop();
    }
}
