using UnityEngine;
using System.Collections;

public abstract class ExperienceSystem {

	// Experience system data
	protected int experience = 0;
	protected int level = 1;

	// Sets the experience points
	public void SetExperience (int experience) {
		this.experience = experience;
	}

	// Returns the experience points
	public int GetExperience () {
		return experience;
	}

	// Sets the level
	public void SetLevel (int level) {
		this.level = level;
	}

	// Returns the level
	public int GetLevel () {
		return level;
	}

	public float GetExperiencePercentage () {
		return experience / (float) RequiredExperience ();
	}

	// Earns the given amount of experience points
	public void EarnExperience (int exp) {
		experience += exp;

		int required = 0;
		while (experience >= (required = RequiredExperience ())) {
			experience -= required;
			level++;
		}
	}

	// Returns the required amount of experience points for level up
	public abstract int RequiredExperience ();
}