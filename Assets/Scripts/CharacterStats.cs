using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {
	public List<BaseStat> stats = new List<BaseStat>();
	
	void Start()
	{
		//*** example coding.. will need alot of work
		//adds a new stat to the character
		stats.Add(new BaseStat(4, "Power", "Your power level."));
		//adds a statBonus.. We know that Power is 0, but we will want a way to identify where to add it better.
		stats[0].AddStatBonus(new StatBonus(5));
		Debug.Log(stats[0].GetCalculatedStatValue());
	}
}
