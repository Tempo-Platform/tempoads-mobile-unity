using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tempo.Unity;

public class ButtonHandler : MonoBehaviour
{
    private TempoAdManager tempoAdManager;

    void Start(){
        tempoAdManager = TempoAdManager.Instance;
        tempoAdManager.Init();
    }

    public void OnRequestAd () {
        tempoAdManager.RequestCollectionAd();
    }

    public void OnShowAd () {
        if(tempoAdManager.IsAdReady()){
            Debug.Log("Ad is ready");
            tempoAdManager.ShowCollectionAd();
        } else {
            Debug.Log("Ad is not ready, yet");
        }
    }
}
