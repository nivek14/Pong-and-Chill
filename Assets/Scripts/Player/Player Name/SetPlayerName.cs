using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class SetPlayerName : MonoBehaviour{

    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private PlayerData playerData;
    
    public void SetName(){
        playerData.playerName = nameInput.text;
    }

}
