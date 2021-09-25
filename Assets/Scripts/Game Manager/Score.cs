using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour{
    
    [SerializeField] private int scoreToFinished;
    private Player player;
    private IA opponent;
    private Ball ball;
    private FinishGame endGame;

    private void Awake(){
        player = FindObjectOfType<Player>();
        opponent = FindObjectOfType<IA>();
        ball = FindObjectOfType<Ball>();
        endGame = FindObjectOfType<FinishGame>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "ScoreForPlayer"){
            player._playerData.playerScore++;
            EndScore();
            ball.ResetBall();
        }
        else if(other.transform.tag == "ScoreForOpponent"){
            opponent._IAscore++;
            EndScore();
            ball.ResetBall();
        }
    }

    private void EndScore(){
        if(player._playerData.playerScore == scoreToFinished || opponent._IAscore == scoreToFinished){
            endGame.EndGame();
        }
    }

}
