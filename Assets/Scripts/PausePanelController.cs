using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePanelController : MonoBehaviour
{
    public Button btnResume;
    public Button btnMenu;
    // Start is called before the first frame update
    void Start()
    {
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
    }
    private void Resume()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    private void GoToMenu()
    {
        //test
        Debug.Log("To menu");
    }
}
