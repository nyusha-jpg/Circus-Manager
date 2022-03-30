using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcrobatHiring : MonoBehaviour
{


        //LITERALLY THE SAME SCRIPT AS "HOW TO HIRE", I ran it through find and replace

    public static int acrobatTrickScore;
    public static int acrobatSafetyScore;
    public static int acrobatSexyScore;
    public static int circusTrickScore;
    public static int circusSafetyScore;
    public static int circusSexyScore;
    public Text acrobatScoreText;
    public Text circusScoreText;
    public static int acrobatTotal;    
   public GameObject acrobat;
   public Transform myCanvas;
   public Vector3 acrobatStart;
   public Vector3 resumeStart;
   public GameObject hire;
   public GameObject pass;
   public GameObject rateMe;
   public List <GameObject> hiredAcrobats = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        rateMe.SetActive(false);
        acrobatTrickScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatSafetyScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatSexyScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatScoreText.text = "Trick Ability:" + acrobatTrickScore.ToString() + "\n Sexiness: " + acrobatSexyScore.ToString() + "\n Safety: " + acrobatSafetyScore; //display the acrobat score
       
        CreateAcrobat();
        // GameObject newAcrobat = Instantiate(acrobat);
        // acrobat.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 0.6f, 1f, 0.6f, 1f);
        // newAcrobat.transform.SetParent(myCanvas);           
        // newAcrobat.transform.localPosition = resumeStart;
        // newAcrobat.transform.localScale = new Vector3 (Random.Range(1.5f, 0.1f), (Random.Range(0.6f, 0.2f)));
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateAcrobat()
    {
        GameObject newAcrobat = Instantiate(acrobat);
        acrobat.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 0.6f, 1f, 0.6f, 1f);
        newAcrobat.transform.SetParent(myCanvas);           
        newAcrobat.transform.localPosition = resumeStart;
        newAcrobat.transform.localScale = new Vector3 (Random.Range(1.5f, 0.1f), (Random.Range(0.6f, 0.2f)));
        hiredAcrobats.Add(newAcrobat);
    }
    public void HireAcrobat()
    {
        acrobatTotal++; 
        hiredAcrobats[hiredAcrobats.Count -1].GetComponent<StateAcrobat>().acrobatCount =  acrobatTotal; //use acrobatTotal from the moment of click, don't keep updating it
        hiredAcrobats[hiredAcrobats.Count -1].GetComponent<StateAcrobat>().currentState = StateAcrobat.State.Move;

       if(acrobatTotal < 9)
       {
        circusTrickScore += acrobatTrickScore; //add the acrobat score to the circus score
        circusSexyScore += acrobatSexyScore; 
        circusSafetyScore += acrobatSafetyScore;
        
    

        acrobatTrickScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatSexyScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatSafetyScore = (int)Random.Range(0, 10); //random number for acrobat score
         acrobatScoreText.text = "Trick Ability:" + acrobatTrickScore.ToString() + "\n Sexiness: " + acrobatSexyScore.ToString() + "\n Safety: " + acrobatSafetyScore;

       

        CreateAcrobat();

        

       }

       else //if(acrobatTotal == 10)
       {
           acrobatTotal++;
        GameObject newAcrobat = Instantiate(acrobat);
        acrobat.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 0.15f, 0.30f, 0.9f, 1f);

        newAcrobat.transform.SetParent(myCanvas);
        Vector3 newPos = new Vector3(acrobatStart.x + acrobatTotal, acrobatStart.y, acrobatStart.z);                  
        newAcrobat.transform.position = newPos;
       newAcrobat.transform.localScale = new Vector3 (1f, 1f);

           hire.SetActive(false);
           pass.SetActive(false);
           rateMe.SetActive(true);

       
       }



        }

    public void PassAcrobat()
    {
        
        if(acrobatTotal <10)
        {

        acrobatTrickScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatSexyScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatSafetyScore = (int)Random.Range(0, 10); //random number for acrobat score
        acrobatScoreText.text = "Trick Ability:" + acrobatTrickScore.ToString() + "\n Sexiness: " + acrobatSexyScore.ToString() + "\n Safety: " + acrobatSafetyScore;

        }

          else
       {
           hire.SetActive(false);
           pass.SetActive(false);
           rateMe.SetActive(true);
       }

        
    }

}
