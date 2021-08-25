using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseResumeScript : MonoBehaviour
{
    //public Button btnPause;
    bool isPaused = false;

    public void PauseGame()
    { 
        if (isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;

        }

        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }

}
