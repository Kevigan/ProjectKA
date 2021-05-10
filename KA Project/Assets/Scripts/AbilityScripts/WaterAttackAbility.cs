using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaterAttack", menuName = "Abilities/WaterAttack", order = 1)]
public class WaterAttackAbility : CharacterAbility
{
    protected override void AbilityStart()
    {
        Debug.Log("WaterAttack");
        OnAbilityEnd();
    }
}
