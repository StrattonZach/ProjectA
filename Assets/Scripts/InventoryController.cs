using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    //defined for testing
    public WeaponController weaponController;
	public Item sword;

	void Start()
	{
        weaponController = GetComponent<WeaponController>();
		List<BaseStat> swordStats = new List<BaseStat>();
		swordStats.Add(new BaseStat(6, "Power", "Your power level"));
		sword = new Item(swordStats, "sword");
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            weaponController.EquipGear(sword);
        }
    }
}
