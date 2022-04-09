using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoScript : MonoBehaviour
{
    public string sceneName = "Menü";

    public int duration = 5;
    public int timeRemaining;
    public bool isCountingDown = false;

    private void Start()
    {
        Begin();
    }

    public void Begin()
    {
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            Invoke("_tick", 1f);
        }
    }

    private void _tick()
    {
        timeRemaining--;
        if (timeRemaining > 0)
        {
            Invoke("_tick", 1f);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
            isCountingDown = false;
        }

    }

}
