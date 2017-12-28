using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public List<BaseStat> Stats { get; set; }
    public string ObjectSlug { get; set; }

    public Item(List<BaseStat> _Stats, string _ObjectSlug)
    {
        //Stats for the items
        this.Stats = _Stats;
        //name of the item to pull the prefab
        this.ObjectSlug = _ObjectSlug;
    }
}
