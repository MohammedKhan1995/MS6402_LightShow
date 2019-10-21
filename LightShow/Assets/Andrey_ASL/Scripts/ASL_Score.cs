using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ASL_Score : MonoBehaviour
{
  



    public static int ScoreV = 0; // score variable
    public Text score;

    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>(); // add a text component to the score.

    }

    // Update is called on  per frame
    void Update() {
        score.text = "Score: " + ScoreV; // score is the score value + whatever score the player has

    }

}
