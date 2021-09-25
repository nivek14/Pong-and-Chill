using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour{

    private ChangeScene goToWinnerScene;
    
    private void Awake(){
        goToWinnerScene = FindObjectOfType<ChangeScene>();
    }

    public void EndGame(){
        goToWinnerScene.LoadScene("Game Hub");
    }

}
