using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinBehavior : MonoBehaviour {
    public Text gamepoints;
    int playerpoints = 0;
    public static AudioClip coin;
    void Start()
    {
        coin = Resources.Load<AudioClip>("Coin");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(this.gameObject);
        
    }
    public float Points
    {
        get { return playerpoints; }
    }
}
