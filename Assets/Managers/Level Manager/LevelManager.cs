using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LevelManager : MonoBehaviour
{

  ScoreManager scoreManager;
  Text levelText;
  int currentLevel = 0;

  // Use this for initialization
  void Start()
  {
    levelText = GetComponentInChildren<Text>();
    levelText.text = "Lv. " + (currentLevel + 1).ToString("n0");
    scoreManager = FindObjectOfType<ScoreManager>();
  }

  public int GetCurrentLevel()
  {
    return currentLevel;
  }

  public void LevelUpCheck()
  {
    try
    {
      if (scoreManager.GetScore() >= Constants.scoreNeededToLevel[currentLevel + 1])
      {
        currentLevel++;
				levelText.text = "Lv. " + (currentLevel + 1).ToString("n0");
      }
    }
    catch (IndexOutOfRangeException e)
    {
      Debug.LogWarning("Player already reached maximum level");
			Debug.LogWarning(e);
    }

  }

}
