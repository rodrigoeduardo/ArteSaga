﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeComplete : MonoBehaviour
{

    public string scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(scene);
    }
}
