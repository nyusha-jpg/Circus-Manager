using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToHire : MonoBehaviour
{

    public static int clownFunnyScore;
    public static int circusFunnyScore;
    public Text clownScoreText;
    public Text circusScoreText;
    public static int clownTotal;

    // Start is called before the first frame update
    void Start()
    {
        clownFunnyScore = (int)Random.Range(-10, 10); //random number for clown score
        clownScoreText.text = "Clown funny score: " + clownFunnyScore.ToString(); //display the clown score
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void HireClown()
    {
        Debug.Log("HIRE current score is " + clownFunnyScore);
        circusFunnyScore += clownFunnyScore; //add the clown score to the circus score
        circusScoreText.text = "Circus funny score: " + circusFunnyScore.ToString();

        clownFunnyScore = (int)Random.Range(-10, 10); //random number for clown score
        clownScoreText.text = "Clown funny score: " + clownFunnyScore.ToString();

        clownTotal++;
        Debug.Log("clown total is" + clownTotal);
    }

    public void PassClown()
    {
        Debug.Log("PASS current score is " + clownFunnyScore);
        clownFunnyScore = (int)Random.Range(-10, 10); //random number for clown score
        clownScoreText.text = "Clown funny score: " + clownFunnyScore.ToString(); //display it
    }

}
