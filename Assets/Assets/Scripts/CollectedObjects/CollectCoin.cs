using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFx;
    public 
    
    void OnTriggerEnter(Collider collider)
    {
        coinFx.Play();
        CollectControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
