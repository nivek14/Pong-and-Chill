using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour{

    [SerializeField] private PlayerData _player;
    [SerializeField] private TextMeshProUGUI nameText;

    private void Awake() {
        ShowPlayerName();
    }

    private void ShowPlayerName(){
        nameText.text = _player.playerName;
    }
    
}
