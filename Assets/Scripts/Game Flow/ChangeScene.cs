using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour{

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }
    
    public void LoadScene(string scene){
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }

}
