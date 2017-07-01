using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject CoinPoofPrefab;
    public AudioClip[] mySound;
    public AudioSource soundSource;
    public void OnCoinClicked() {
        soundSource.clip = mySound[0];
        soundSource.Play();
    }

}
