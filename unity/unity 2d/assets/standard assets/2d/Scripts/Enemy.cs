using UnityEngine;
using System.Collections;


/**
 * Basic enemy class which does stuff like rotating the enemy picture.
 * 
 * @autor Rubin Kallugjeri
 */
public class Enemy : CombatEntity {
     /*
	public Player player;

	public PickUp drop;
   
	private Vector3 rotation = new Vector3();

	private Collision2D collision;

	void Update () {
		Vector2 playerPosition = player.transform.position;
		Vector2 enemyPosition = transform.position;

		Vector2 direction = playerPosition - enemyPosition;
		direction.Normalize ();

		rotation.z = Mathf.Atan2 (-direction.x, direction.y) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.Euler (rotation);
		transform.Translate (Vector2.up * movementSpeed * Time.deltaTime);

		TickAttackCooldown ();
	}

	void OnCollisionStay2D (Collision2D collision) {
		if (collision.gameObject.tag == Constants.TAG_PLAYER) {
			if (CanAttack ()) {
				if (attackSound != null && !attackSound.isPlaying) {
					attackSound.time = 0.3f;
					attackSound.Play ();
				}
				collision.gameObject.SendMessage ("TakeDamage", GetDamage ());
				ResetAttackCooldown ();
			}
		}
	}

	void OnCollisionExit2D (Collision2D collision) {
		if (attackSound != null && attackSound.isPlaying) {
			attackSound.Stop ();
		}
	}

	public void EarnExperienceIfDead () {
		if (IsAlive ()) {
			return;
		}

		
		if (drop.DropChance () >= Random.value) {
			Instantiate (drop, transform.position, Quaternion.identity);
		}

		// Earn player experience
		player.EarnExperience (GetWorthExperience ());
        player.setKillCount(player.getKillCount() + 1);
        
	}
    */
}