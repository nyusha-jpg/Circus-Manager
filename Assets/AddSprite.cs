using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSprite : MonoBehaviour
{
   //public SpriteRenderer clownSprite;
   public GameObject clown;
   public Transform myCanvas;
   public Vector3 clownStart;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewSprite()
    {
        GameObject newClown = Instantiate(clown);
        newClown.transform.SetParent(myCanvas);
        Vector3 newPos = new Vector3(clownStart.x + HowToHire.clownTotal, clownStart.y, clownStart.z);                  
        newClown.transform.position = newPos;
        newClown.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        

    }
}
