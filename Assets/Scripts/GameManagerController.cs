using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerController : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("LeftPlayer")]
    public GameObject leftPlayer;
    public GameObject leftGoal;

    [Header("RightPlayer")]
    public GameObject rightPlayer;
    public GameObject rightGoal;

    [Header("ScoreUI")]
    public GameObject leftPlayerScore;
    public GameObject rightPlayerScore;

    [Header("FX Sound")]
    public AudioSource fxSound;

    private int leftScore;
    private int rightScore;

    public void ManageLeftScore()
    {
        fxSound.Play();
        leftScore++;
        leftPlayerScore.GetComponent<TextMeshProUGUI>().text = leftScore.ToString();
        ResetPosition();
    }

    public void ManageRightScore()
    {
        fxSound.Play();
        rightScore++;
        rightPlayerScore.GetComponent<TextMeshProUGUI>().text = rightScore.ToString();
        ResetPosition();
    }

    void ResetPosition()
    {
        ball.GetComponent<BallController>().Reset();
        leftPlayer.GetComponent<LeftPlayerController>().Reset();
        rightPlayer.GetComponent<RightPlayerController>().Reset();
    }
}
