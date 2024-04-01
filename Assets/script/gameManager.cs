using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    
    public GameObject panelPaus;

    public void PauseControl() {
        if (Time.timeScale == 1) {
            panelPaus.SetActive (true);
            Time.timeScale = 0;
        } else {
            Time.timeScale = 1;
            panelPaus.SetActive (false);
        }
    }

    public void Restart() {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1; 
    }

    public void menuUtama() {
        Application.LoadLevel(0);
    }

    
}
