using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeSongIcon : MonoBehaviour{

    [SerializeField] private Sprite _pauseSong;
    [SerializeField] private Sprite _continueSong;
    private Image _imageToUse;

    private void Awake(){
        Init();
    }

    private void Init(){
        _imageToUse = GetComponent<Image>();
        _imageToUse.sprite = _continueSong;
    }

    public void ChangeImage(){
        if(_imageToUse.sprite == _pauseSong) _imageToUse.sprite = _continueSong;
        else _imageToUse.sprite = _pauseSong;
    }

}
