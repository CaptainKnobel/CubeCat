using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausegame : MonoBehaviour {
    public GameObject pauseMenu;
    private bool keyDown = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            keyDown = !keyDown;
            PauseGame();
        }

    }
    public void PauseGame()
    {
        

        if (keyDown)
        {
            
            showPauseMenu();

        }
        else
        {
            UnpauseGmae();
        }

    }
    public void showPauseMenu()
    {
        pauseMenu.active = true;
        Time.timeScale = 0;
    }
    public void UnpauseGmae()
    {
        pauseMenu.active = false;
        Time.timeScale = 1;
    }



}