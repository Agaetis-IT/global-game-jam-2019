﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowIntro()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        if (Input.anyKeyDown && !Input.GetKey(KeyCode.Mouse0) && !Input.GetKey(KeyCode.Mouse1) && !Input.GetKey(KeyCode.Escape))
        {
            this.PlayGame();
        }
    }
}
