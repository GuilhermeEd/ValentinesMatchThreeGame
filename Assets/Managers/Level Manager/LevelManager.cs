using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LevelManager : MonoBehaviour
{

  public static int currentLevel;
  
  ScoreManager scoreManager;
  ShapesManager shapesManager;
  SoundManager soundManager;
  GameManager gameManager;
  Text levelText;
  Timer timer;

  // Use this for initialization
  void Start()
  {
    levelText = GetComponentInChildren<Text>();
    levelText.text = "Lv. " + (currentLevel).ToString("n0");
    scoreManager = FindObjectOfType<ScoreManager>();
    shapesManager = FindObjectOfType<ShapesManager>();
    soundManager = FindObjectOfType<SoundManager>();
    gameManager = FindObjectOfType<GameManager>();
    timer = FindObjectOfType<Timer>();
  }

  public int GetCurrentLevel()
  {
    return currentLevel;
  }

  public int SetCurrentLevel(int value)
  {
    return currentLevel = value;
  }

  public void LevelSuccessCheck()
  {
    if (scoreManager.GetScore() >= Constants.scoreNeededToLevel[currentLevel])
    {
      timer.Reset();
      shapesManager.Bonus();
      soundManager.PlayPowerUp();
      gameManager.OnLevelSuccess();
    }
  }

}
