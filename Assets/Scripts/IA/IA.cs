using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IA : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI _IAscoreText;
    [SerializeField] private Ball ball;
    [SerializeField] private float followSpeed;
    public int _IAscore;

    void Awake(){
        Init();
    }

    void Update(){
        ShowIAscore();
        IAMovement();
    }

    private void Init(){
        _IAscore = 0;
    }

    private void ShowIAscore(){
        _IAscoreText.text = _IAscore.ToString();
    }

    private void IAMovement(){
        Vector3 followXonly = new Vector3(ball.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, followXonly, followSpeed * Time.deltaTime);
    }

}
