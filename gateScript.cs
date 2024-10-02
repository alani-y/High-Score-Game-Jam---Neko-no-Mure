using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateScript : MonoBehaviour
{
    // Start is called before the first frame update

    public logicManager logic;
    private catScript cat;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicManager>();
        cat = GameObject.FindGameObjectWithTag("cat").GetComponent<catScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider){
        /*
        Debug.Log(cat.sit);
        if(!GetComponent<Collider2D>().gameObject.CompareTag("player")){
            logic.addScore();
        }
        
        if(!cat.sit){
            logic.addScore();
        } */
        
    }
}
