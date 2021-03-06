﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public TMP_InputField sensInputBox;
    float rfloat;
    string rstring;

    void Start()
    {
        rfloat = PlayerPrefs.GetFloat("Sensitivity", 30);
        rstring = rfloat.ToString("F2");
        sensInputBox.text = rstring;
    }

    public void sensChange ()
    {
        if(sensInputBox.text != "")
        {
            PlayerPrefs.SetFloat("Sensitivity", float.Parse(sensInputBox.text));
        }
    }
}
