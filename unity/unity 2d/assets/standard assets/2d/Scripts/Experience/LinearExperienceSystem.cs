using UnityEngine;
using System.Collections;

public class LinearExperienceSystem : ExperienceSystem {

	// Experience per level
	protected int experiencePerLevel = 10000;

	// Sets the experience per level in a linear graph
	public void SetExperiencePerLevel (int experiencePerLevel) {
		this.experiencePerLevel = experiencePerLevel;
	}

	// Returns the experience per level
	public int GetExperiencePerLevel () {
		return experiencePerLevel;
	}

	// Returns the required amount of experience points for level up
	public override int RequiredExperience () {
		return level * experiencePerLevel;
	}
}