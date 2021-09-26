using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour{
    
    public void LoadScene(string scene){
        FindObjectOfType<Canvas>().gameObject.SetActive(false);
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }

}
