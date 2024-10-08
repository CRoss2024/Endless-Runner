using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI scoreText;
    public float scoreValue = 0f;
    public float pointIncreasedPerSecond = 1f;
    public bool scoreIncreasing;

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreValue);
    }
}
