using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMulti : MonoBehaviour{
    
    [SerializeField] private int scoreToFinishedMax = 3, scoreToFinishedMinimum = -3;
    [SerializeField] private AudioClip scoreClip;
    [SerializeField] private GameObject scoreEffect;
    private AudioSource audioSource;
    private ParticleSystem system;
    private PlayerMulti player;
    private BallMulti ball;
    private FinishGame endGame;
    public int generalScore;

    private void Awake(){
        audioSource = FindObjectOfType<AudioSource>();
        system = GetComponent<ParticleSystem>();
        player = FindObjectOfType<PlayerMulti>();
        ball = FindObjectOfType<BallMulti>();
        endGame = FindObjectOfType<FinishGame>();
        generalScore = 0;
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.transform.tag == "ScorePlus"){
            audioSource.PlayOneShot(scoreClip);
            system.Play(scoreEffect);
            generalScore++;
            EndScore();
        }
        else if(other.transform.tag == "ScoreLess"){
            audioSource.PlayOneShot(scoreClip);
            system.Play(scoreEffect);
            generalScore--;
            EndScore();
        }   
    
    }

    private void EndScore(){
        if(generalScore == scoreToFinishedMax || generalScore == scoreToFinishedMinimum){
            Debug.Log("here");
            endGame.EndGame();
        }
    }

}
