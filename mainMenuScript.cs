using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    public string Level;
    public string startScreen;
    public string credits;
    // Start is called before the first frame update
  
    void Start(){
        
    }

    void Update(){

    }

    public void startGame(){

        Debug.Log("starting..");
        SceneManager.LoadScene(Level);
    }
    
    public void levels(){
   
        Debug.Log("levels");
    }

    public void loadCredits(){
  
        SceneManager.LoadScene(credits);
    }

    public void back(){
 
        Debug.Log("back");
        SceneManager.LoadScene(startScreen);
    }
}
