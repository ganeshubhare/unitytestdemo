using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class LogAnalytics : MonoBehaviour {

	// Use this for initialization
	void Start() {
		LevelUp();
	}

	void LevelUp()
	{
		Gender gender = Gender.Female;
		Analytics.SetUserGender(gender);

		int birthYear = 1973;
		Analytics.SetUserBirthYear(birthYear);

		Analytics.Transaction("8084a65e-2d60-4267-9d46-c9bbc74feb40", 1m, "GBP", null, null);

		Analytics.CustomEvent("gameOver", new Dictionary<string, object>
		{
			{ "potions", 1},
			{ "coins", 100 },
			{ "activeWeapon", "Second level activated"}
		});



	}

	// Update is called once per frame
	void Update () {
	
	}
}
