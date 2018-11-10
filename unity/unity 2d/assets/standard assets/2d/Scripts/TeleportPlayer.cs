using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportPlayer : MonoBehaviour {
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(-402.2f, -198.5f, -5);

        }
        if (col.gameObject.tag == "Bullet")
        {
            

        }
    }
}
