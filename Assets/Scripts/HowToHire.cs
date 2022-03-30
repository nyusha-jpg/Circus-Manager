using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToHire : MonoBehaviour
{

    //scores to keep track of   
    public static int clownFunnyScore;
    public static int clownBalloonScore;
    public static int clownMakeupScore;
    public static int circusFunnyScore;
    public static int circusBalloonScore;
    public static int circusMakeupScore;
    public Text clownScoreText; //stats
    public Text circusScoreText;
    public static int clownTotal;    //how many clowns have you hired


    public GameObject clown; //sprite
    public Transform myCanvas; //canvas
    public Vector3 clownStart; //where clowns go once hired
    public Vector3 resumeStart; //where clowns go upon...... birth

    //buttons
    public GameObject hire;
    public GameObject pass;


    public GameObject nextScene; //acrobat button
    public List<GameObject> hiredClowns = new List<GameObject>(); //create list for the state machine to keep hired clowns in

    // Start is called before the first frame update
    void Start()
    {
        nextScene.SetActive(false); //remove button
        clownFunnyScore = (int)Random.Range(0, 10); //random number for clown score
        clownBalloonScore = (int)Random.Range(0, 10); //random number for clown score
        clownMakeupScore = (int)Random.Range(0, 10); //random number for clown score
        clownScoreText.text = "Funniness:" + clownFunnyScore.ToString() + "\n Makeup Ability: " + clownMakeupScore.ToString() + "\n Balloon Animal Craft: " + clownBalloonScore; //display the clown score

        CreateClown(); //make clown sprite appear
    }



        // Update is called once per frame
        void Update()
        {

        }


        public void CreateClown()
        {
            GameObject newClown = Instantiate(clown); //create clown sprite
            clown.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 0.6f, 1f, 0.6f, 1f); //give it a random color
            newClown.transform.SetParent(myCanvas);           //put it on the canvas
            newClown.transform.localPosition = resumeStart; //put it on this start position
            newClown.transform.localScale = new Vector3(Random.Range(1.5f, 0.1f), (Random.Range(0.6f, 0.2f))); //make it a random size
            hiredClowns.Add(newClown); //add to the list of hired clowns
        }

        public void HireClown() //all the stuff that happens when you click Hire clown
        {
            clownTotal++;  //add to the clown total
            hiredClowns[hiredClowns.Count - 1].GetComponent<StateMachine>().clownCount = clownTotal; //use clownTotal from the moment of click, don't keep updating it
            hiredClowns[hiredClowns.Count - 1].GetComponent<StateMachine>().currentState = StateMachine.State.Move; //move when hired

            if (clownTotal < 9)
            {
                    //add individual clown scores to the circus score
                circusFunnyScore += clownFunnyScore;
                circusMakeupScore += clownMakeupScore;
                circusBalloonScore += clownBalloonScore;

                clownFunnyScore = (int)Random.Range(0, 10); //random number for clown score
                clownMakeupScore = (int)Random.Range(0, 10); //random number for clown score
                clownBalloonScore = (int)Random.Range(0, 10); //random number for clown score
                clownScoreText.text = "Funniness:" + clownFunnyScore.ToString() + "\n Makeup Ability: " + clownMakeupScore.ToString() + "\n Balloon Animal Craft: " + clownBalloonScore; //print scores


                CreateClown(); //make a new sprite

            }

            else //on the tenth clown
            {

                //make the clown like numbers 1-9 before
                clownTotal++;
                GameObject newClown = Instantiate(clown);
                clown.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 0.6f, 1f, 0.6f, 1f);

                newClown.transform.SetParent(myCanvas);
                Vector3 newPos = new Vector3(clownStart.x + clownTotal, clownStart.y, clownStart.z);
                newClown.transform.position = newPos;
                newClown.transform.localScale = new Vector3(Random.Range(1.5f, 0.1f), (Random.Range(0.6f, 0.2f)));


                //BUT ON THE TENTH CLOWN!!
                hire.SetActive(false); //hide hire button
                pass.SetActive(false); //hide pass button
                nextScene.SetActive(true); //show button to move on to acrobats


            }


        }

        public void PassClown() //pass button
        {

            if (clownTotal < 10)
            {
                clownFunnyScore = (int)Random.Range(0, 10); //random number for clown score
                clownMakeupScore = (int)Random.Range(0, 10); //random number for clown score
                clownBalloonScore = (int)Random.Range(0, 10); //random number for clown score
                clownScoreText.text = "Funniness:" + clownFunnyScore.ToString() + "\n Makeup Ability: " + clownMakeupScore.ToString() + "\n Balloon Animal Craft: " + clownBalloonScore;

            }

        }
    }

