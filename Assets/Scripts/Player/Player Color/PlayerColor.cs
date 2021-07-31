using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerColor : MonoBehaviour{

    [SerializeField] private PlayerData playerData;

    public void DefinedColor(Image img){
        playerData.playerColor = img.color;
    }

    public void RandomColor(){
        playerData.playerColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

}
