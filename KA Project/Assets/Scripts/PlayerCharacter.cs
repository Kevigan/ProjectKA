using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : CharacterController2D
{
    Vector2 moveInput;
    [SerializeField] private float speed;
    //CharacterAbility dashAbility, attackAbility, chargedAttackAbility;
    [SerializeField] private CharacterAbility switchAbility;

    [SerializeField] private AbilityPool firePool, waterPool;
    private AbilityPool currentAbilities;


    protected override void Start()
    {
        base.Start();
        ChangeAbilities(firePool);
        switchAbility.Setup(this);
    }
    private void Update()
    {
        currentAbilities.DashAbility.AbilityUpdate();
        currentAbilities.AttackAbility.AbilityUpdate();
        currentAbilities.ChargeAbility.AbilityUpdate();
        switchAbility.AbilityUpdate();
    }
    private void FixedUpdate()
    {
        Move(moveInput * speed);
    }

    private void ChangeAbilities(AbilityPool newAbilities)
    {
        currentAbilities.AttackAbility = newAbilities.AttackAbility;
        currentAbilities.DashAbility = newAbilities.DashAbility;
        currentAbilities.ChargeAbility = newAbilities.ChargeAbility;

        currentAbilities.AttackAbility.Setup(this);
        currentAbilities.DashAbility.Setup(this);
        currentAbilities.ChargeAbility.Setup(this);
    }

    public void SwitchAbilities()
    {
        if(currentAbilities.AttackAbility = firePool.AttackAbility)
        {
            ChangeAbilities(waterPool);
        }
        else
        {
            ChangeAbilities(firePool);
        }
    }
    #region InputFunctions
    public void MoveInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    public void DashInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            currentAbilities.DashAbility.OnButtonDown();
        }
        if (context.canceled)
        {
            currentAbilities.DashAbility.OnButtonUp();
        }
    }
    public void ChargedAttackInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            currentAbilities.ChargeAbility.OnButtonDown();
        }
        if (context.canceled)
        {
            currentAbilities.ChargeAbility.OnButtonUp();
        }
    }
    public void AttackInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            currentAbilities.AttackAbility.OnButtonDown();
        }
        if (context.canceled)
        {
            currentAbilities.AttackAbility.OnButtonUp();
        }
    }
    public void SwitchInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            switchAbility.OnButtonDown();
        }
        if (context.canceled)
        {
            switchAbility.OnButtonUp();
        }
    }
    #endregion
}

[System.Serializable]
public struct AbilityPool
{
    public CharacterAbility ChargeAbility;
    public CharacterAbility AttackAbility;
    public CharacterAbility DashAbility;
}
