using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityStandardAssets._2D
{
   
    public class Restarter : MonoBehaviour
         
    {
        public Image l1;
        public Image l2;
        public Image l3;

        public int lifecounter = 3;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            while (lifecounter > 0)
            {
                if (other.tag == "Player")
                {
                    SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
                }
                switch (lifecounter)
                {
                    case 3:
                        Destroy(l1.gameObject);
                        break;
                    case 2:
                        Destroy(l2.gameObject);
                        break;
                    case 1:
                        Destroy(l1.gameObject);
                        break;
                }
                lifecounter--;
            }
        }
    }
}
