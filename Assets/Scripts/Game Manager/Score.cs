using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour{
    
    [SerializeField] private int scoreToFinished;
    [SerializeField] private AudioClip scoreClip;
    [SerializeField] private GameObject scoreEffect;
    private AudioSource audioSource;
    private ParticleSystem system;
    private Player player;
    private IA opponent;
    private Ball ball;
    private FinishGame endGame;

    private void Awake(){
        audioSource = FindObjectOfType<AudioSource>();
        system = GetComponent<ParticleSystem>();
        player = FindObjectOfType<Player>();
        opponent = FindObjectOfType<IA>();
        ball = FindObjectOfType<Ball>();
        endGame = FindObjectOfType<FinishGame>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "ScoreForPlayer"){
            audioSource.PlayOneShot(scoreClip);
            system.Play(scoreEffect);
            player._playerData.playerScore++;
            EndScore();
            ball.ResetBall();
        }
        else if(other.transform.tag == "ScoreForOpponent"){
            audioSource.PlayOneShot(scoreClip);
            system.Play(scoreEffect);
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
