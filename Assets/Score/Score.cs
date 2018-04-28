using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

  private static Text scoreText;

  void Awake()
  {
		scoreText = GetComponentInChildren<Text>();
  }

	public static float GetScore() {
		return ShapesManager.GetScore();
	}

  public static void SetScoreText(int value) {
    scoreText.text = value.ToString("n0");
  }

}
