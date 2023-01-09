using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCollider1 : MonoBehaviour
{
    public static int score = 0;
    //if(score == null) {
    //    score = 0;
   // }

    //GameObject collider1; 
    public GameObject obj;
   // obj = GameObject.Find("Jhonny.................Appleseed");
    //public void hideobj(GameObject obj) {
        
    //}
    void Start() {
        Debug.Log("Script Started");
    }
  
   void OnTriggerEnter (Collider col) 
   {
    Debug.Log(col.name);
   
     score = score + 100;
   
    obj.SetActive(false);
    Debug.Log(score);
    
   //  cradle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 500) {
            SceneManager.LoadScene(0);
        }
    }
}
