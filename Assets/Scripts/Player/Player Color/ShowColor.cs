using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowColor : MonoBehaviour{

    [SerializeField] PlayerData playerData;
    private Image image;

    private void Awake() {
        image = GetComponent<Image>();
    }

    void Update(){
        image.color = playerData.playerColor;
    }

}
