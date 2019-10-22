using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Unity tool that allows scenes to change automatically.
using UnityEngine.UI;                // Unity tool that allows the script to change the UI

public class ASL_PlayerHP : MonoBehaviour
{
    public float TimeHP = 120f;  // Starting hp

    public string GameOverScene = "GameOverScene";        // Reference to the scene that will be loaded when HP reaches 0  // variable on how much hp the object has.
    public Text Timer;                           // Reference to the UI's health bar.
    public Slider Slider;

    private void Start()
    {
        //StartCoroutine("Countdown");
    }

    void Update()
    {

        Slider.value = TimeHP;
        Timer.text = "" + TimeHP;
        {
            //Debug.Log(Slider.value);
        }

        Countdown();
    }

    void Countdown()
    {
        TimeHP -= Time.deltaTime;
        Timer.text = "" + TimeHP;
        if (TimeHP <= 0)    // if the target's HP reaches 0
        {
            GameOver();     // Call game over function
        }
    }

    void GameOver()
    {
        ASL_Score.ScoreV = 0;
        SceneManager.LoadScene(GameOverScene);
    }
}