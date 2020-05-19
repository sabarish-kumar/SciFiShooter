using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DisplayScore : MonoBehaviour
{
    public GameObject displayScoreText;


    void Update()
    {
        
        displayScoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + (int)ScoringSystem.theScore;

        
    }
}
