using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    bool music = true;
    bool sound = true;
    public AudioSource MusicSound;
    public GameObject MusicObj;
    public AudioListener camlist;
    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    public GameObject camlistObj;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void ToMenu()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }
    public void Settings()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }
    public void Music(bool on)
    {
        if (on)
        {
            music = true;
        }
       else if (!on)
        {
            music = false;
        }
    }
    public void Sounds(bool on)
    {
        if (on)
        {
            sound = true;
        }
        else if (!on)
        {
            sound = false;
        }
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
        public void Exit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        if (music == false)
        {
            MusicObj = GameObject.Find("Music");
            MusicSound = MusicObj.GetComponent<AudioSource>();
            MusicSound.enabled = false;
        }
        if (sound == false)
        {
            camlistObj = GameObject.Find("Main Camera");
            camlist = camlistObj.GetComponent<AudioListener>();
            camlist.enabled = false;
        }
    }
}
