using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FailModal : MonoBehaviour
{

  Text missingScore;
  ScoreManager scoreManager;
  LevelManager levelManager;

  static FailModal singleton;

  void Awake()
  {
    if (singleton == null)
    {
      singleton = this;
    }
    else
    {
      Destroy(gameObject);
    }
  }

  void Start()
  {
    missingScore = transform.Find("Container").Find("Score").Find("Value").GetComponent<Text>();
    scoreManager = FindObjectOfType<ScoreManager>();
    levelManager = FindObjectOfType<LevelManager>();

    int scoreNeeded = Constants.scoreNeededToLevel[levelManager.GetCurrentLevel()];
    int scoreAchieved = scoreManager.GetScore();
    missingScore.text = (scoreNeeded - scoreAchieved).ToString("n0");
  }

  public void TryAgain()
  {
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
  }

  public void Exit()
  {
		int mapSceneIndex = 0;
		SceneManager.LoadScene(mapSceneIndex);
  }
}
