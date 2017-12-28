using System.Collections;
using System.Collections.Generic;

public interface IWeapon
{
    //Basic Interface for Weapons.. all weapons will require this.. Need range
    List<BaseStat> Stats { get; set; }
    void PerformAttack();
}
