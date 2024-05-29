using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PanelPauyse;
    void Start()
    {
        
    }
    public void PauseVoid()
    {
        Time.timeScale = 0;
        PanelPauyse.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        PanelPauyse.SetActive(false);
    }
    void Update()
    {
        
    }
}
