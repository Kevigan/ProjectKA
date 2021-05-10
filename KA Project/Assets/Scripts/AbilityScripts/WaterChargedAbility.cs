using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaterCharged", menuName = "Abilities/WaterCharged", order = 1)]
public class WaterChargedAbility : CharacterAbility
{
    protected override void AbilityStart()
    {
        Debug.Log("WaterCharge");
        OnAbilityEnd();
    }
}
