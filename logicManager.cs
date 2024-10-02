using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicManager : MonoBehaviour
{
    public int catNum;
    public Text numText;
    public GameObject gameOver;
    public AudioSource meow1;
    [ContextMenu("Increase Score")]

    void Start(){
        gameOver.SetActive(false);
    }

    void Update(){
        //Debug.Log(catNum);
        if(catNum == 5){
            meow1.Play();
            gameOver.SetActive(true);
        }
    }
    public void addScore()
    {
        
            catNum += 1;
            numText.text = (catNum.ToString() + "/5 cats found");
    }
 
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    

}
