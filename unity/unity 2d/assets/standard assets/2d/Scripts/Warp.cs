using UnityEngine;
using System.Collections;

/**
 * Basic warp system for the player.
 * 
 * @project 2D Fighting GameObject
 * @autor Rubin Kallugjeri
 */
public class Warp : MonoBehaviour {

	// Warp target
	public Transform warpTarget;

	// On trigger enter
	/*IEnumerator void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == Constants.TAG_PLAYER) {
			ScreenFade sf = GameObject.FindGameObjectWithTag (Constants.TAG_SCREEN_FADE).GetComponent<ScreenFade> ();

			//yield return StartCoroutine (sf.FadeToBlack ());
			collider.gameObject.transform.position = warpTarget.position;
			//yield return StartCoroutine (sf.FadeToClear ());
		}

	}
    */
}