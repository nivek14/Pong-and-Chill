using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour{
    
    private Player player;
    private IA opponent;
    private Ball ball;

    private void Awake(){
        player = FindObjectOfType<Player>();
        opponent = FindObjectOfType<IA>();
        ball = FindObjectOfType<Ball>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "ScoreForPlayer"){
            player._playerData.playerScore++;
            ball.ResetBall();
        }
        else if(other.transform.tag == "ScoreForOpponent"){
            opponent._IAscore++;
            ball.ResetBall();
        }
    }

}
