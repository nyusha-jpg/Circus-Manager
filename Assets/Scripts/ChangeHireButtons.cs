using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHireButtons : MonoBehaviour
{
    public GameObject itsAMe; //the button this script is attached to
    public GameObject hireAcrobat;
    public GameObject passAcrobat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButtons()
    {
      //  hireClown.SetActive(false);
       // passClown.SetActive(false);
        hireAcrobat.SetActive(true);
        passAcrobat.SetActive(true);
        itsAMe.SetActive(false);
    }
}
