using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class PlayerMulti : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI _playerScore;
    [SerializeField] public PlayerData _playerData;
    [SerializeField] private float _speed;
    private Canvas canvas;
    private Rigidbody2D _rb;
    private Image _playerImg;
    private float _Xpos; 

    private void Awake(){
        Init();    
    }

    private void Update(){
        PlayerMovement();
        ShowPlayerScore();
    }

    private void Init(){
        _rb = GetComponent<Rigidbody2D>();
        _playerImg = GetComponent<Image>();
        _playerImg.color = _playerData.playerColor;
        _playerData.playerScore = 0;
        canvas = FindObjectOfType<Canvas>();
        gameObject.transform.SetParent(canvas.transform);
    }

    private void PlayerMovement(){
        _Xpos = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(_Xpos, _rb.velocity.y).normalized * _speed;
    }

    private void ShowPlayerScore(){
        //_playerScore.text = _playerData.playerScore.ToString();
    }

}
