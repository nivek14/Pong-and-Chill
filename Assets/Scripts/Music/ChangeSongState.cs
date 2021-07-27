using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ChangeSongState : MonoBehaviour{

    [SerializeField] private Sprite _pauseSong;
    [SerializeField] private Sprite _continueSong;
    private Radio _radio;
    private Image _imageToUse;
    private Button _button;
    private void Awake(){
        Init();
    }

    private void Init(){
        _radio = FindObjectOfType<Radio>();
        _imageToUse = GetComponent<Image>();
    }

    private void Start(){
        SetSpriteToUse();
    }

    private void SetSpriteToUse(){
        if(_radio.audioSource.isPlaying){
            _imageToUse.sprite = _pauseSong;
        }
        else{
            _imageToUse.sprite = _continueSong;
        }
    }

    public void ChangeState(){
        if(!_radio.audioSource.isPlaying){
            _imageToUse.sprite = _pauseSong;
            _radio.audioSource.Play();
        }
        else{
            _imageToUse.sprite = _continueSong;
            _radio.audioSource.Pause();
        }
    }

}
