//This code is written by Riley Bottesch specifically for the Gameplay Modification requirement!!//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AbilityDash : Abilities
{
    [SerializeField]
    private int boostPercentage;
    [SerializeField]
    private RubyController playerMove;
 
    private float boostAsPercent;
    private void Start()
    {
        playerMove = GetComponent<RubyController>();
        boostAsPercent = (100 + boostPercentage) / 100;
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= abilityTimer && Input.GetKeyDown(KeyCode.LeftShift))
        {
            AbilityEffect();
            abilityTimer = Time.time + cooldown;
        }
    }
 
    private void AbilityEffect()
    {
     
        playerMove.Boost(boostAsPercent);
 
        Invoke("ResetAbility", duration);
    }
 
    private void ResetAbility()
    {
     
        playerMove.ResetBoost(boostAsPercent);
    }
}