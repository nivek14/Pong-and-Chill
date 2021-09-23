using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{

    [SerializeField] private Vector3 speed = new Vector3(0.5f, 0.5f);
    private Vector3 startSpeed;
    private Vector3 startPosition;

    void Awake(){
        gameObject.SetActive(true);
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
        if(other.transform.tag == "Player") speed.y *= -1;
        else speed.x *= -1; 
    }

    public void ResetBall(){
        transform.position = startPosition;    
        speed = startSpeed;
    }

}
