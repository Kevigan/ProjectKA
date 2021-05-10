using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FireDash", menuName = "Abilities/FireDash", order = 0)]
public class FireDashAbility : CharacterAbility
{
    protected override void AbilityStart()
    {
        Debug.Log("FireDash");
        OnAbilityEnd();
    }

}
