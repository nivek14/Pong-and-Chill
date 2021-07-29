using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ShowSongName : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI _songName;
    private Radio _radio;

    private void Awake() {
        Init();
    }

    private void Init(){
        _radio = FindObjectOfType<Radio>();
        SongName();
    }

    private void Update() {
        UpdateSongName();
    }

    private void UpdateSongName(){
        if(_songName.text != _radio.audioSource.clip.name) SongName();
    }

    private void SongName(){
        _songName.text = _radio.audioSource.clip.name;
    }

}
