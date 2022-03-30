using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircusName : MonoBehaviour
{
    public Text inputText; //where the player types the name
    public Text fancyCircusName; //the textbox where the name will appear at the top
    public GameObject CircusFancyName; //the object of the text
    public GameObject submitButton; //the submit button
    public GameObject sceneChangeButton; //go to hiring scene
    public GameObject gameStats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetName() {
        fancyCircusName.text = inputText.text; //apply the circus name
        CircusFancyName.SetActive(true); //show the circus name text
        sceneChangeButton.SetActive(true); //show the next scene button
      
    }

}
