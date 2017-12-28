using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
    //whole script needs work.. should be a equipment controller, and the "type" determines what slot it will be competing for. 

    public GameObject playerHand;
    public GameObject EquippedGear { get; set; }

    IWeapon equippedWeapon;
    CharacterStats characterStats;

    private void Start()
    {
        characterStats = GetComponent<CharacterStats>();

    }
    //***** commenting every line for later overhall
    public void EquipGear(Item itemToEquip)
    {
        if(EquippedGear != null)
        {
            characterStats.RemoveStatBonus(EquippedGear.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0).gameObject);
        }
        //Equipping gear other the weapon would have to locate the folder itemToEquip.ItemType + itemToEquip.ObjectSlug
        //instantiate the item from the Item itemToEquip... can get the type from here also
        EquippedGear = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/" + itemToEquip.ObjectSlug), playerHand.transform.position, playerHand.transform.rotation);
        //sets the equippedWeapon to the IWeapon interface.. So it is only called once, and we can get the required info
        equippedWeapon = EquippedGear.GetComponent<IWeapon>();
        //sets the stats of the weapon to the item that was equipped
        equippedWeapon.Stats = itemToEquip.Stats;
        //sets the equipment parent to the body part it needs. Needing for animations
        EquippedGear.transform.SetParent(playerHand.transform);
        //adds the stats from the item to the player
        characterStats.AddStatBonus(itemToEquip.Stats);
        //debug the value that was added form the items added
        Debug.Log(itemToEquip.Stats[0].GetCalculatedStatValue());
    }

    public void PerformWeaponAttack()
    {
        equippedWeapon.PerformAttack();
    }
}
