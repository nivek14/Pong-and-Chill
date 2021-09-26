using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{

    [SerializeField] private Vector3 speed = new Vector3(0.5f, 0.5f);
    [SerializeField] private AudioClip pongClip;
    private AudioSource audioSource;
    private Vector3 startSpeed;
    private Vector3 startPosition;

    void Awake(){
        audioSource = FindObjectOfType<AudioSource>();
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
        if(other.transform.tag == "Player"){
            audioSource.PlayOneShot(pongClip);
            speed.y *= -1;
        }
        else{
            audioSource.PlayOneShot(pongClip);
            speed.x *= -1; 
        }
    }

    public void ResetBall(){
        transform.position = startPosition;    
        speed = startSpeed;
    }

}
