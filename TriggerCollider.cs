using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{
    public int score = 0;
   void OnTriggerEnter () 
   {
    score = score + 100;
    Debug.Log("+100 points");
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 500) {
            
        }
    }
}
