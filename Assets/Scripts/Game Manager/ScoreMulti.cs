using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMulti : MonoBehaviour{
    
    [SerializeField] private int scoreToFinishedMax = 3, scoreToFinishedMinimum = -3;
    private PlayerMulti player;
    private BallMulti ball;
    private FinishGame endGame;
    public int generalScore;

    private void Awake(){
        player = FindObjectOfType<PlayerMulti>();
        ball = FindObjectOfType<BallMulti>();
        endGame = FindObjectOfType<FinishGame>();
        generalScore = 0;
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.transform.tag == "ScorePlus"){
            generalScore++;
            EndScore();
        }
        else if(other.transform.tag == "ScoreLess"){
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
