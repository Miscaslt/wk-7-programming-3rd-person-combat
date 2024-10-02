using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State // make sure theres no monobehaviour because state scripts shuoldnt be attached to game objects, because we only access these states through the player state machines
{

    // enter function called when a new state is entered, similar to start function but its used to prepare the current state
    public abstract void Enter();

    /*
     * tick function is like update function executes every frame while the state is entered
     */
    public abstract void Tick(float deltaTime);

    /*
     * call exit function when we exit the state, to tidy up and transition to next state
     */

    public abstract void Exit();

    // any state must have these 3 functions, e.g. attack; when it starts we call enter, then while its running we run Tick() and when we finish and go to another state we use Exit()
}
