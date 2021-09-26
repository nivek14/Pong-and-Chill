using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCanvas : MonoBehaviour{

    private void Update() {
        if(!gameObject.activeSelf){
            gameObject.SetActive(true);
        }
    }

}
