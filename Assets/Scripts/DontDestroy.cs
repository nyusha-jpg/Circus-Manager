using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour

{
    void Awake() //as soon as the world exists
    {
        DontDestroyOnLoad(this.gameObject); //what it says on the tin! dont destroy on load
    }
}

