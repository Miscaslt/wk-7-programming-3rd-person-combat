using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseStates // this takes the default functionality from player base states, and can overwrite it
{

    //we need to make a default constructor, with stateMachine function as a parameter, which passes this as the 1st function when game starts; base(stateMachine) is to make sure it uses the base state machine is assigned(?)
   // dont need to override the contructor but we overrride the other functions that we inherit
    public PlayerTestStates(PlayerStateMachine stateMachine) : base(StateMachine)
    {
      
    }


    public override void Enter()
    {
        // to test if the state machine works:
        
    }

    public override void Exit()
    {
        Debug.Log("exiting state");
    }
    public override void Tick(float deltatime)
    {
        Vector3 movement = new Vector3();
        movement.x = stateMachine.inputReader.MovementValue.x; // get left and right input value from input reader; this is the benefit of using input reader to get values from all events in the input reader; e.g. everytime we press a button,  the input reader gets the updated value and puts it here
        movement.y = 0;
        movement.x = stateMachine.inputReader.MovementValue.y;
        // these values from input reader are in Vector3

        //to apply input values from statemachine to the player:
        stateMachine.transform.Translate(movement * deltatime); //not the ideal way but to test that statemachine works to give player movement

    }
}
