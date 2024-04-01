using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paus : MonoBehaviour
{
    public bool paused;
    public void PauseGame() {
        paused = !paused;
        if (paused) {
            Time.timeScale = 0;
        } else if (!paused) {
            Time.timeScale = 1;
        }
    }
}
