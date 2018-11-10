using UnityEngine;
using System.Collections;

public class CombatEntity : Entity {

	// Hit Points
	public float maxHitPoints = 100;
	public float hitPoints = 100;

	// Damage
	public float damage = 10.0f;

	// Attack speed in seconds (1s = 1000ms)
	public float attackSpeed = 1;
	public float attackCooldown = 0;
	public float movementSpeed = 1.5f;

	public bool drawHealthBar = true;

	// Sounds
	public AudioSource attackSound;

	// Textures
	protected Texture2D black;
	protected Texture2D gray;
	protected Texture2D red;

	// Renders the GUI
	void OnGUI() {
		if (black == null) {
			black = CreateColoredTexture (new Color (0.0f, 0.0f, 0.0f, 1.0f));
			gray = CreateColoredTexture (new Color (0.5f, 0.5f, 0.5f, 1.0f));
			red = CreateColoredTexture (new Color (0.7f, 0.1f, 0.0f, 1.0f));
		}


		if (drawHealthBar && !HasFullHealth ()) {
			Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
			screenPosition.y = Screen.height - screenPosition.y;

			float width = Mathf.Max (hitPoints / 2.0f, 5);
			float maxWidth = Mathf.Max (maxHitPoints / 2.0f, 5);

			GUI.skin.box.normal.background = black;
			GUI.Box (new Rect (screenPosition.x - maxWidth / 2.0f - 1, screenPosition.y - 41, maxWidth + 2, 8), GUIContent.none);
			GUI.skin.box.normal.background = red;
			GUI.Box (new Rect (screenPosition.x - width / 2.0f, screenPosition.y - 40, width, 6), GUIContent.none);
		}
	}

	// Draws the attack cooldown bar
	protected void DrawAttackCooldownBar () {
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		screenPosition.y = Screen.height - screenPosition.y;

		float width = Mathf.Max ((attackSpeed - attackCooldown) * 25.0f, 5);
		float maxWidth = Mathf.Max (attackSpeed * 25.0f, 5);

		GUI.skin.box.normal.background = black;
		GUI.Box (new Rect (screenPosition.x - maxWidth / 2.0f - 1, screenPosition.y - 31, maxWidth + 2, 6), GUIContent.none);
		GUI.skin.box.normal.background = gray;
		GUI.Box (new Rect (screenPosition.x - width / 2.0f, screenPosition.y - 30, width, 4), GUIContent.none);
	}

	// Sets if the health bar should be drawn
	public void SetDrawHealthBar (bool drawHealthBar) {
		this.drawHealthBar = drawHealthBar;
	}

	// Returns if the health bar should be drawn
	public bool GetDrawHealthBar () {
		return drawHealthBar;
	}

	// Sets the max hit points
	public void SetMaxHitPoints (float maxHitPoints) {
		this.maxHitPoints = maxHitPoints;
	}

	// Returns the max hit points
	public float GetMaxHitPoints () {
		return maxHitPoints;
	}

	// Sets the hit points
	public void SetHitPoints (float hitPoints) {
		this.hitPoints = hitPoints;
	}

	// Returns the hit points
	public float GetHitPoints () {
		return hitPoints;
	}

	// Returns the hit points in percentage
	public float GetHitPointsPercentage () {
		return hitPoints / maxHitPoints;
	}

	// Checks if the combat entity has full health
	public bool HasFullHealth () {
		return hitPoints >= maxHitPoints;
	}

	// Takes the given amount of damage
	public virtual void TakeDamage (float dmg) {
		hitPoints = Mathf.Max (hitPoints - dmg, 0);
	}

	// Receives the given amount of health
	public virtual void ReceiveHeal (float health) {
		hitPoints = Mathf.Clamp (hitPoints + health, 0, maxHitPoints);
	}

	// Heals the combat entity to max health
	public void HealToMaxHealth () {
		hitPoints = maxHitPoints;
	}

	// Kills this combat entity
	public void Kill () {
		hitPoints = 0;
	}

	// Checks if the combat entity is dead
	public bool IsDead () {
		return hitPoints <= 0;
	}

	// Checks if the combat entity is alive
	public bool IsAlive () {
		return !IsDead ();
	}

	// Sets the damage output
	public void SetDamage (float damage) {
		this.damage = damage;
	}

	// Returns the damage output
	public float GetDamage () {
		return damage;
	}

	// Sets the attack speed (in seconds)
	public void SetAttackSpeed (float attackSpeed) {
		this.attackSpeed = attackSpeed;
	}

	// Returns the attack speed (in seconds)
	public float GetAttackSpeed () {
		return attackSpeed;
	}

	// Checks if the combat entity can attack
	public bool CanAttack () {
		return attackCooldown <= 0;
	}

	// Resets the attack cooldown
	public void ResetAttackCooldown () {
		attackCooldown = attackSpeed;
	}

	// Ticks the attack cooldown
	public void TickAttackCooldown () {
		if (attackCooldown >= 0) {
			attackCooldown -= Time.deltaTime;
		}
	}

	// Sets the movement speed
	public void SetMovementSpeed (float movementSpeed) {
		this.movementSpeed = movementSpeed;
	}

	// Returns the movement speed
	public float GetMovementSpeed () {
		return movementSpeed;
	}

	// Destroys this combat entity
	public void Destroy () {
		Destroy (gameObject);
	}

	// Destroys this combat entity only if it is dead
	public void DestroyIfDead() {
		if (IsDead ()) {
			Destroy ();
		}
	}
}