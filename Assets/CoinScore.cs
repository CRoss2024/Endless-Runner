using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class CoinScore : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int score;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score += 1;
        }
    }

    private void Update()
    {
        coinText.text = score.ToString();
    }
}
