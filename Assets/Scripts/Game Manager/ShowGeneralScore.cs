using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowGeneralScore : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI generalScoreText;
    private ScoreMulti score;

    private void Update() {
        if(FindObjectOfType<ScoreMulti>()){
            score = FindObjectOfType<ScoreMulti>();
            generalScoreText.text = score.generalScore.ToString();
        }
    }

}
