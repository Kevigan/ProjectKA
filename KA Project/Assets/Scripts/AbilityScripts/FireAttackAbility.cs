using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FireAttack", menuName = "Abilities/FireAttack", order = 0)]
public class FireAttackAbility : CharacterAbility
{
    protected override void AbilityStart()
    {
        Debug.Log("FireAttack");
        OnAbilityEnd();
    }
    protected override void OnAbilityButtonUp()
    {
        
    }
}
