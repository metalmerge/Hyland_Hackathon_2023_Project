using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
  
   public void Start1() 
   {
    Debug.Log("Hello world");
    SceneManager.LoadScene("SampleScene");
   }
   public void Start2() 
   {
   
    SceneManager.LoadScene("Credits");
   }
    public void Start3() 
    {
    SceneManager.LoadScene("Main menu");
   }
   void Update() {
    if ( Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("Esc Pressed");
           Application.Quit();
    }
   }
}
