using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// manages transition between states
public abstract class StateMachine : MonoBehaviour
{
    private State currentState;
    public void SwitchState(State newState)
    {
        // if w e##e have a current state, tidy up the current state and prepare transition to new state
        currentState?.Exit();
        // set the current state to the new state
        currentState = newState;
        //prepare the new state
        currentState.Enter();
        //? is to make sure current state isnt null then calls exit, so it only exits if there is a current state set; if there is no current state set at the start of the game, it wont exit
    
    }

private void Update()
    {
        // 
        currentState?.Tick(Time.deltaTime);

    }

}

// these 2 classes are common for any state machine; can use it as a base to make other state machines like player or enemy state machine; make them inehrit from state class