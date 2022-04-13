using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Image playButton;
    public Image exitButton;
    public AudioSource fxSound;

    public void PlayGame()
    {
        fxSound.Play();
        StartCoroutine(Delay());
    }

    public void BackGame()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("PlayScene");
    }
}
