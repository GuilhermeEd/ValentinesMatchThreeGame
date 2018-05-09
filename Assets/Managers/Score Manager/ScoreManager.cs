using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{

  Text scoreText;
  Slider slider;
  LevelManager levelManager;

  void Start()
  {
    scoreText = transform.Find("Score Text").Find("Value").GetComponent<Text>();
    slider = GetComponentInChildren<Slider>();
    levelManager = FindObjectOfType<LevelManager>();
  }

  public int GetScore()
  {
    return ShapesManager.GetScore();
  }

  public void SetScore(int value)
  {
    try
    {
      int lv = levelManager.GetCurrentLevel();
      int scoreNeeded = Constants.scoreNeededToLevel[lv];
      int score = GetScore();
      float progress = (float) (score) / (scoreNeeded);
      scoreText.text = (progress * 100).ToString("n2") + "%";
      slider.value = progress;
      levelManager.LevelSuccessCheck();
    }
    catch (IndexOutOfRangeException e)
    {
      Debug.LogWarning("Player already reached maximum level");
      Debug.LogWarning(e);
    }
  }

}
