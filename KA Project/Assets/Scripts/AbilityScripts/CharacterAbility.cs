using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterAbility : ScriptableObject
{
    public bool IsOnCooldown { get => _maxCooldown > 0; }
    [SerializeField] private float maxCooldown = 3f;
    private float _maxCooldown;

    protected PlayerCharacter player;

    public void Setup(PlayerCharacter player)
    {
        this.player = player;
    }
    public void OnButtonDown()
    {
        if (IsOnCooldown) return;
        AbilityStart();
    }
    public void OnButtonUp()
    {
        OnAbilityButtonUp();
    }

    public void HandleCooldown()
    {
        if (!IsOnCooldown) return;
        _maxCooldown -= Time.deltaTime;
    }
    protected void OnAbilityEnd()
    {
        _maxCooldown = maxCooldown;
    }

    public void AbilityUpdate()
    {
        HandleCooldown();
    }

    protected virtual void AbilityStart() { }
    protected virtual void OnAbilityButtonUp() { }
    protected virtual void Update() { }
}
