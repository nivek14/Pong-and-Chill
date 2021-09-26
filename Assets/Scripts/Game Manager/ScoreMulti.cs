using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMulti : MonoBehaviour{
    
    [SerializeField] private int scoreToFinished;
    private PlayerMulti player;
    private IA opponent;
    private BallMulti ball;
    private FinishGame endGame;

    private void Awake(){
        player = FindObjectOfType<PlayerMulti>();
        opponent = FindObjectOfType<IA>();
        ball = FindObjectOfType<BallMulti>();
        endGame = FindObjectOfType<FinishGame>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "ScoreForPlayer"){
            //player._playerData.playerScore++;
            //EndScore();
            ball.ResetBall();
        }
    }

    /*private void EndScore(){
        if(player._playerData.playerScore == scoreToFinished || opponent._IAscore == scoreToFinished){
            endGame.EndGame();
        }
    }*/

}
