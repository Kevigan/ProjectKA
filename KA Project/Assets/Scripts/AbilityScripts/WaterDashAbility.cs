using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaterDash", menuName = "Abilities/WaterDash", order = 1)]
public class WaterDashAbility : CharacterAbility
{
    protected override void AbilityStart()
    {
        Debug.Log("WaterDash");
        OnAbilityEnd();
    }
}
