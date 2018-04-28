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
      int lastScoreNeeded = Constants.scoreNeededToLevel[lv];
      int scoreNeeded = Constants.scoreNeededToLevel[lv + 1];
      int score = GetScore();

      scoreText.text = value.ToString("n0");
      slider.value = (float) (score - lastScoreNeeded) / (scoreNeeded - lastScoreNeeded);
      levelManager.LevelUpCheck();
    }
    catch (IndexOutOfRangeException e)
    {
      Debug.LogWarning("Player already reached maximum level");
      Debug.LogWarning(e);
    }
  }

}
