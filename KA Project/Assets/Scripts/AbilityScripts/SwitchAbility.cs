using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Switch", menuName = "Abilities/Switch", order = 2)]
public class SwitchAbility : CharacterAbility
{
    protected override void AbilityStart()
    {
        player.SwitchAbilities();
        Debug.Log("Switch");
        OnAbilityEnd();
    }
}
