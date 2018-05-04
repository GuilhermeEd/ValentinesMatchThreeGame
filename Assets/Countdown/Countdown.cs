using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{

  GameManager gameManager;

  void Start()
  {
    gameManager = FindObjectOfType<GameManager>();
  }

  public void StartGame()
  {
		gameManager.StartGame();
		Destroy(gameObject);
  }

}
