using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IA : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI _IAscoreText;
    public int _IAscore;

    void Awake(){
        Init();
    }

    void Update(){
        ShowIAscore();
    }

    private void Init(){
        _IAscore = 0;
    }

    private void ShowIAscore(){
        _IAscoreText.text = _IAscore.ToString();
    }

}
