using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SuccessModal : MonoBehaviour
{

  Text score;
  ScoreManager scoreManager;

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
    score = transform.Find("Container").Find("Score").Find("Value").GetComponent<Text>();
    scoreManager = FindObjectOfType<ScoreManager>();

    score.text = scoreManager.GetScore().ToString("n0");
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
