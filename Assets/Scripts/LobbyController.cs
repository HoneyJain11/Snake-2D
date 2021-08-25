using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    public string newScene;

    private void Awake()
    {
        playButton.onClick.AddListener(StartPlay);
        quitButton.onClick.AddListener(Quit);
    }

    public void StartPlay()
    {
        SceneManager.LoadScene(newScene);
    }

    public void Quit()
    {  
        Application.Quit();
    }
}
