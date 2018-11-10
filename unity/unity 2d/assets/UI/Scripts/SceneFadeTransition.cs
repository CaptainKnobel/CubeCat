using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFadeTransition : MonoBehaviour {

	public Texture2D fadeTexture;

	public float fadeInSpeed = 0.05f;
	public float fadeOutSpeed = 0.05f;

	public int sceneIndex = 1;

	public float delay = 3;

	public bool fadeOut = true;

	private float alpha = 1.0f;
	private float waited = 0;

	// Use this for initialization
	void OnGUI() {
		if (fadeOut) {
			waited += Time.deltaTime;
		}

		if (waited < delay) {
			alpha -= fadeInSpeed * Time.deltaTime;
		} else {
			alpha += fadeOutSpeed * Time.deltaTime;
		}

		alpha = Mathf.Clamp (alpha, 0, 1);

		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeTexture);

		if (fadeOut && alpha >= 1 && waited > delay) {
			SceneManager.LoadScene (sceneIndex);
		}
	}
}
