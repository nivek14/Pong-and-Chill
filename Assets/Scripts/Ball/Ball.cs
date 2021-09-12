using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{

    [SerializeField] private Vector2 speedRandX = new Vector2(1, 3);
    [SerializeField] private Vector2 speedRandY = new Vector2(1, 3);
    private Vector3 speed = new Vector3(1, 1);
    private Vector3 startSpeed;
    private Vector3 startPosition;
    private bool canMove = false;

    void Awake(){
        startPosition = transform.position;
        startSpeed = speed;
    }

    void Update(){
        Movement();
    }

    private void Movement(){
        if(!canMove) return;
        transform.Translate(speed);
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.transform.tag == "Player") OnPlayerCollision();
        else speed.y *= -1;
    }

    private void OnPlayerCollision(){

        float rand = Random.Range(speedRandX.x, speedRandY.y);

        if(speed.x < 0) rand = -rand; 
        speed.x = rand;

        rand = Random.Range(speedRandY.x, speedRandY.y);
        speed.y = rand;

    }

    public void ResetBall(){
        transform.position = startPosition;    
        speed = startSpeed;
    }

    public void CanMove(bool state){
        canMove = state;
    }
    
}
