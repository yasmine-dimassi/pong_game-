﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour
{
    public static MenuNavigation instance;

    //to get the username
    public static string usernameString = "Anonymous";
    public Text username;

    private void Update()
    {
        //return 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Username");
        }
    }

    public void Start()
    {
        username.text = usernameString;
    }
    public void Play()
    {
        SceneManager.LoadScene("Theme");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
