using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // kita buat variabel score untuk menyimpan skor
    float totalScore;

    private void Start()
    {
        // reset skor ke 0 tiap game dimulai dari awal
        ResetScore();
    }

    public void AddScore(float poin)
    {
        // tambah skor berdasarkan parameter
        totalScore += poin;
        Debug.Log(totalScore);
    }

    public void ResetScore()
    {
        // kembalikan skor ke 0 untuk situasi tertentu
        totalScore = 0;
    }

    public float getScore(){
        return totalScore;
    }
}

