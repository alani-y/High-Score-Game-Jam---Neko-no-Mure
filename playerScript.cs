using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{   
    
    public Rigidbody2D player;
    public float speed;

    public static PlayerScript Instance {get; private set;}
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
        player.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {   
        if(Instance == null){
            Instance = this;
        }
        
        // horizontal movement
        if(Input.GetKey(KeyCode.A)) {
            
            player.velocity = Vector2.left * speed;
        }
        else if(Input.GetKey(KeyCode.D)){
            
            player.velocity = Vector2.right * speed;
        }
        else{

        }

        //vertical movement
        if(Input.GetKey(KeyCode.W)){
            player.velocity = Vector2.up * speed;
        }
        else if(Input.GetKey(KeyCode.S)){
            player.velocity = Vector2.down * speed;
        }
        else{
            
        }

        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
            
            player.velocity.Set(0.0f, player.velocity.y);
            Debug.Log(player.velocity);
            
        }
        if(Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W)) {
            player.velocity.Set(player.velocity.x, 0.0f);
            
        }
        playerPos();
    }

    // gets the player's position
    public Vector3 playerPos() {
        return player.transform.position;
    }
    
    public Vector3 playerVelocity(){
        return player.velocity;
    }

}
