using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinPanelScript : MonoBehaviour
{
    public TextMeshPro text;
    public Button btnRestart;
    public Button btnLobby;
    public Button btnQuit;

    public SnakeController snakeController;

    public void Restart()
    {
        gameObject.SetActive(false);
        snakeController.Restart();
       
    }

    public void GoToLobby()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(0);
        
    }
    public void Quit()
    {
        Application.Quit();        
    }
}
