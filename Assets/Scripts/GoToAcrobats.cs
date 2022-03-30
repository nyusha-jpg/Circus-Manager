using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAcrobats : MonoBehaviour
{
    public void GoToNextScene(string ClownHiring)
    {
     SceneManager.LoadScene(ClownHiring); //load the clownhiring scene
    }
}
