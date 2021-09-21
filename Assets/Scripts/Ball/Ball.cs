using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{

    //[SerializeField] private Vector2 speedRandX = new Vector2(1, 3);
    //[SerializeField] private Vector2 speedRandY = new Vector2(1, 3);
    [SerializeField] private Vector3 speed = new Vector3(0.5f, 0.5f);
    private Vector3 startSpeed;
    private Vector3 startPosition;

    void Awake(){
        startPosition = transform.position;
        startSpeed = speed;
    }

    void Update(){
        Movement();
    }

    private void Movement(){
        transform.Translate(speed);
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.transform.tag == "Player"){
            //OnPlayerCollision();
            speed.y *= -1;
        }
        else speed.x *= -1; 
    }

    /*private void OnPlayerCollision(){

        float rand = Random.Range(speedRandY.x, speedRandY.y);

        if(speed.y > 0) rand = -rand; 
        speed.y = rand;

        rand = Random.Range(speedRandX.x, speedRandX.y);
        speed.x = rand;

    }*/

    public void ResetBall(){
        transform.position = startPosition;    
        speed = startSpeed;
    }

}
