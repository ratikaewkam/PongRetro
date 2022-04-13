using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManagerController : MonoBehaviour
{
    public GameObject displayWinner;
    private string msg;

    // Start is called before the first frame update
    void Start()
    {
        msg = PlayerPrefs.GetString("msg");
        displayWinner.GetComponent<Text>().text = msg;
    }
}
