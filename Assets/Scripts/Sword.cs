using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon {
	//rename to melle weapon? another interface? all close range weapons will have this, and another script for individual use.
	public List<BaseStat> Stats { get; set; }

	public void PerformAttack()
	{
		Debug.Log("Sword Attack");
	}
}
