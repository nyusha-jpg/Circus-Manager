using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAcrobat : MonoBehaviour
{

    /////THIS IS THE EXACT SAME CODE AS STATEMACHINE, I just ran it through find and replace for the acrobats 


    
   public Vector3 spriteFinalPos;
   public int acrobatCount;
    public enum State
    {
        Birth,
        Move,
        Idle
    }

    public State currentState;
    // Start is called before the first frame update
    void Start()
    {
        currentState = State.Birth;
    }

    // Update is called once per frame
    void Update()
    {
        TransitionStates(currentState);
       // Debug.Log("spriteFinalPos is" + spriteFinalPos);
    }

    public void TransitionStates(State newState)
    {
        currentState = newState;
        switch (newState)
        {

            case State.Birth:
                break;

            case State.Move:{

                float step = 150.0f * Time.deltaTime;
                Vector3 newPos = new Vector3(spriteFinalPos.x + (acrobatCount * 40), spriteFinalPos.y, 0);
                gameObject.transform.localPosition = Vector3.MoveTowards(transform.localPosition, newPos, step);
            
                float dis = Vector3.Distance(transform.localPosition, newPos);
                if (dis < 0.1f)
                {
                    currentState = State.Idle;
                }

                break;
            }
            case State.Idle:
                break;
        }

        
    }

}
