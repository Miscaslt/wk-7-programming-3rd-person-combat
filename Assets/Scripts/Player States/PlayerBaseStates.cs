using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//we want to modify this from the base state machine to be used for player states; inherit from state class. this is abstract so we dont need to implelent the functions, we'll make other classes where we need to implement the functions
public abstract class PlayerBaseStates : State
{
    protected PlayerStateMachine stateMachine;

    // use class name as function name
    public void PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    // constructor is a function to initialize things when game starts, when the reference of a class is created, or else youll get an error
}
