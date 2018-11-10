using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {

	public Rigidbody2D rb2D;
	public Animator animator;

	public int worthExperience = 0;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}

	// Creates a new 1x1 colored texture
	protected Texture2D CreateColoredTexture(Color color) {
		Texture2D result = new Texture2D (1, 1);
		result.filterMode = FilterMode.Point;
		result.SetPixel(0, 0, color);
		result.Apply();
		return result;
	}

	// Sets the rigid body
	public void SetRigidbody2D (Rigidbody2D rb2D) {
		this.rb2D = rb2D;
	}

	// Returns the rigid body
	public Rigidbody2D GetRigidbody2D () {
		return rb2D;
	}

	// Sets the animator
	public void SetAnimator (Animator animator) {
		this.animator = animator;
	}

	// Returns the animator
	public Animator GetAnimator() {
		return animator;
	}

	// Sets the experience this entity is worth
	public void SetWorthExperience (int worthExperience) {
		this.worthExperience = worthExperience;
	}

	// Returns the experience the entity is worth
	public int GetWorthExperience () {
		return worthExperience;
	}

	// Update is called once per frame
	void Update () {
	}
}