using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DirectorController : MonoBehaviour
{
    public GameObject displayLeftScore;
    public GameObject displayRightScore;
    private string msg;
    private int leftScore;
    private int rightScore;

    // Update is called once per frame
    void Update()
    {
        checkScore();
    }

    public void checkScore()
    {
        string leftValue = displayLeftScore.GetComponent<TextMeshProUGUI>().text;
        string rightValue = displayRightScore.GetComponent<TextMeshProUGUI>().text;
        leftScore = int.Parse(leftValue);
        rightScore = int.Parse(rightValue);

        if (leftScore == 10)
        {
            msg = "Left player win";
            PlayerPrefs.SetString("msg", msg);
            SceneManager.LoadScene("WinScene");
        } 
        else if (rightScore == 10)
        {
            msg = "Right player win";
            PlayerPrefs.SetString("msg", msg);
            SceneManager.LoadScene("WinScene");
        }
    }
}
