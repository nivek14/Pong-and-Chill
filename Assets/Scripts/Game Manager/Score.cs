using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour{
    
    [SerializeField] private Player player;
    [SerializeField] private IA opponent;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "ScoreForPlayer") player._playerData.playerScore++;
        else if(other.transform.tag == "ScoreForOpponent") opponent._IAscore++;
    }

}
