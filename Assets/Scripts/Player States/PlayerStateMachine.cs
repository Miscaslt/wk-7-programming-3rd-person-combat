using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attached to player; tells game what the 1st stae is
public class PlayerStateMachine : MonoBehaviour
{
   // [field: SerializedField] // serializsed field exposes variable in editor; field lets the get and set variables get displayed, without it the field for input reader wouldnt be exposed
    public InputReader inputReader { get; private set; }
    // this is to get infor from input reader script;we can only access info that comes in the state machine, but not override it because the set is private

// to set player test state as default state; theres a function for this in the state machine class; we have access to the public functions of other classes

    private void Start()
    {
        SwitchState(new PlayerTestState(this)); // whenever we make a new player state we
    }
}
