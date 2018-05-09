using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SuccessModal : MonoBehaviour
{

  Text progress;
  ScoreManager scoreManager;
  LevelManager levelManager;
  int scoreNeeded;

  static SuccessModal singleton;

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
    progress = transform.Find("Container").Find("Score").Find("Value").GetComponent<Text>();
    scoreManager = FindObjectOfType<ScoreManager>();
    levelManager = FindObjectOfType<LevelManager>();
    scoreNeeded = Constants.scoreNeededToLevel[levelManager.GetCurrentLevel()];
    int scoreAchieved = scoreManager.GetScore();
    progress.text = (((float)scoreAchieved / scoreNeeded) * 100).ToString("n2") + "%";
  }

  void Update()
  {
    int scoreAchieved = scoreManager.GetScore();
    progress.text = (((float)scoreAchieved / scoreNeeded) * 100).ToString("n2") + "%";
  }

  public void TryAgain()
  {
    Scene scene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(scene.name);
  }

  public void Continue()
  {
    int mapSceneIndex = 0;
    SceneManager.LoadScene(mapSceneIndex);
  }

}
