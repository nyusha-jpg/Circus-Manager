using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Review : MonoBehaviour

{
    public Text finalReview;
    public GameObject finalReviewObject; //so I can show/hide it
    public GameObject thisButton;
    public int[ ] finalScores; //the numbers
    public string [ ] badText; //the sentences
    public string [ ] okayText;
    public string [ ] goodText;


    // Start is called before the first frame update
    void Start()
    {
        finalScores = new int[ ]{HowToHire.circusFunnyScore, HowToHire.circusBalloonScore, HowToHire.circusMakeupScore, AcrobatHiring.circusTrickScore, AcrobatHiring.circusSafetyScore, AcrobatHiring.circusSexyScore}; //all the scores!!!
        badText = new string[]{"The clowns were cancelled online for their tasteless jokes.", "The balloon animals looked like road kill.", "The clown makeup looked like a half-blind mortician applied it.", "The acrobatic tricks were totally boring.", "The unsafe performance got your circus investigated by OSHA.", "There was zero eye candy."}; //you did bad kid
        okayText = new string[]{"The audience had a few chuckles.", "The balloon animals were all worms and snakes.", "The clown's makeup was a little last season.", "The acrobats had some okay cartwheels.", "The acrobats had a few slips and falls- OSHA is watching.", "The sinewy muscules of the performers caught some eyes."}; //you did okay kid
        goodText = new string []{"It was the funniest show of the decade.", "The balloon animals, incredibly, looked like biblically accurate angels.", "The beauty of the clown makeup was akin to the Sistine Chapel." , "The acrobats contorted into incredible shapes.", "The performers did not break a sweat at all.", "Everyone on stage could have been signed to a modeling agency."}; //you did good kid
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintReview(){ //do this when the review button is clicked
        
        thisButton.SetActive (false); //hide the button itself
        finalReviewObject.SetActive (true); //show the text box

        for(int i = 0; i < finalScores.Length; i++){ //For each score, do this stuff. Keep track of how many scores you've done this for. Run it again for the next score.

            if (finalScores[i] <= 30) //if the score point is less than this
            {
                if (i == 0) //for the first score
                {finalReview.text = badText[i];} //print the bad sentence
                
                if (i > 0) //for the rest of the scores... 
                {finalReview.text = finalReview.text + "\n" + badText[i];} //keep printing sentences on a new line

            }

            //same but for medium scores
            if (finalScores[i] >= 31 && finalScores[i] <= 54)
            {
                if (i == 0)
                {finalReview.text = okayText[i];}
                
                if (i > 0)
                {finalReview.text = finalReview.text + "\n" + okayText[i];}

            }

            //same but for good scores
            if (finalScores[i] >= 55)
            {
                if (i == 0)
                {finalReview.text = goodText[i];}
                
                if (i > 0)
                {finalReview.text = finalReview.text + "\n" + goodText[i];}
            }
    }
}
}
