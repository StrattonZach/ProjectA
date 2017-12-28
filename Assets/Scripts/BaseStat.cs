using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStat
{
    //the value of the stat before anything modifies it
    public int BaseValue { get; set; }
    public string StatName { get; set; }
    public string StatDescription { get; set; }
    //the vlaue of the stat after all modifiers
    public int FinalValue { get; set; }

    public List<StatBonus> BaseAdditives { get; set; }

    //Creates a new stat, and assigns it the to the values.
    public BaseStat(int baseValue, string statName, string statDecription)
    {
        this.BaseAdditives = new List<StatBonus>();
        this.BaseValue = baseValue;
        this.StatName = statName;
        this.StatDescription = statDecription;
    }

    //add to stats from the list of stats
    public void AddStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Add(statBonus);
    }
    //Finds the first statBonus that matches and removes it
    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Remove(BaseAdditives.Find(x => x.BonusValue == statBonus.BonusValue));
    }

    public int GetCalculatedStatValue()
    {
        //set the FinalValue to 0 so it doesn't stack when adjusting value. 
        this.FinalValue = 0;
        //add all the bonusValues that were added to the BaseAdditives to FinalValue
        this.BaseAdditives.ForEach(x => this.FinalValue += x.BonusValue);
        //add the new FinalValue to the BaseValue
        FinalValue += BaseValue;
        return FinalValue;
    }
}
