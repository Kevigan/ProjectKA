using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FireCharged", menuName = "Abilities/FireCharged", order = 0)]

public class FireChargedAbility : CharacterAbility
{
    protected override void AbilityStart()
    {
        Debug.Log("FireCharge");
        OnAbilityEnd();
    }
}
