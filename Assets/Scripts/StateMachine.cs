using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
   public Vector3 spriteFinalPos; //where the sprite ends up
   public int clownCount;
    public enum State
    {
        Birth, //first state
        Move, //movement
        Idle //last state
    }

    public State currentState; //tracks current state

    // Start is called before the first frame update
    void Start()
    {
        currentState = State.Birth; //first state is birth
    }

    // Update is called once per frame
    void Update()
    {
        TransitionStates(currentState); 
    }

    public void TransitionStates(State newState)
    {
        currentState = newState; //change to a new state
        switch (newState)
        {

            case State.Birth:
            //nothing happens. just chill.
                break;

            case State.Move:{

                float step = 150.0f * Time.deltaTime; //speed of movement
                Vector3 newPos = new Vector3(spriteFinalPos.x + (clownCount * 45), spriteFinalPos.y, 0); //new position is the final position plus the number of sprites already there to space them out
                gameObject.transform.localPosition = Vector3.MoveTowards(transform.localPosition, newPos, step); //movement

                float dis = Vector3.Distance(transform.localPosition, newPos); //distance to final position
                if (dis < 0.1f) //when you reach it
                {
                    currentState = State.Idle; //stop moving. do nothing. peace out. go to idle.
                }

                break;
            }
            case State.Idle:
            //nothing happens again. keep chilling until the end of the game. forever and ever.
                break;
        }

        
    }

}
