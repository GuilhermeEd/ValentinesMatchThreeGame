using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  [SerializeField] GameObject successModal;
  [SerializeField] GameObject failModal;
  [SerializeField] GameObject canvas;

  public bool gameStarted = false;

  Timer timer;

  void Start()
  {
    timer = FindObjectOfType<Timer>();
  }

  public void OnTimeUp()
  {
    timer.Stop();
    LevelFail();
  }

  public void OnLevelSuccess()
  {
    timer.Stop();
    LevelSuccess();
  }

  void LevelSuccess()
  {
    Vector3 middleOfScreen = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
    GameObject modal = Instantiate(successModal, middleOfScreen, Quaternion.identity);
    modal.transform.SetParent(canvas.transform);
  }

  void LevelFail()
  {
    Vector3 middleOfScreen = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
    GameObject modal = Instantiate(failModal, middleOfScreen, Quaternion.identity);
    modal.transform.SetParent(canvas.transform);
  }

  public void StartGame()
  {
    gameStarted = true;
    timer.Init();
  }

}
