using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreMonitor : MonoBehaviour
{
    public IntVariable marioScore;
    public Text text;
    public void UpdateScore()
    {
        text.text = "Score: " + marioScore.Value.ToString();
    }

    public void Start()
    {
        UpdateScore();
    }

    void OnApplicationQuit(){
        marioScore.SetValue(0);
    }
}