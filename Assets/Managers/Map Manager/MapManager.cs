﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{

    public GameObject[] levelLoaders;

    PlayerPrefsManager playerPrefsManager;

    void Awake()
    {
        playerPrefsManager = FindObjectOfType<PlayerPrefsManager>();
        for (int i = 1; i <= playerPrefsManager.GetUnlockedLevels(); i++)
        {
            UnlockLevel(i);
        }
    }

    void UnlockLevel(int level)
    {
        try
        {
            GameObject levelLoader = levelLoaders[level - 1];
            Image image = levelLoader.GetComponentsInChildren<Image>()[0];
            Image buttonImage = levelLoader.GetComponentsInChildren<Image>()[1];
            Button button = levelLoader.GetComponentInChildren<Button>();
            image.color = Color.white;
            Color buttonColor = buttonImage.color;
            buttonColor.a = 1;
            buttonImage.color = buttonColor;
            button.enabled = true;
        }
        catch (IndexOutOfRangeException e)
        {
            e.ToString();
            int endScene = playerPrefsManager.GetUnlockedLevels();
            LevelLoader loader = new LevelLoader();
            loader.LoadLevel(endScene);
        }
    }
}
