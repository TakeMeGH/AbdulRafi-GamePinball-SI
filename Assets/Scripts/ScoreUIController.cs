using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    // reference ke score manager
    ScoreManager scoreManager;

    private void Start() {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
    }
    private void Update()
    {
        scoreText.text = "Score : " + scoreManager.getScore().ToString();
    }
}
