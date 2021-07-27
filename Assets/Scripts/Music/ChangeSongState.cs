using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ChangeSongState : MonoBehaviour{

    [SerializeField] private Sprite _pauseSong;
    [SerializeField] private Sprite _continueSong;
    [SerializeField] private Radio _radio;
    private Image _imageToUse;
    private void Awake(){
        Init();
    }

    private void Init(){
        _imageToUse = GetComponent<Image>();
        _imageToUse.sprite = _continueSong;
    }

    public void ChangeState(){
        if(_imageToUse.sprite == _continueSong){
            _imageToUse.sprite = _pauseSong;
            _radio.PlaySong();
        }
        else{
            _imageToUse.sprite = _continueSong;
            _radio.PauseSong();
        }
    }

}
