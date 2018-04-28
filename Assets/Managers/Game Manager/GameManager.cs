using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  [SerializeField] GameObject successModal;
  [SerializeField] GameObject failModal;
  [SerializeField] GameObject canvas;


  public void OnTimeUp()
  {
    LevelFail();
  }

  void LevelSuccess()
  {
    Vector3 middleOfScreen = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
    GameObject modal = Instantiate(successModal, middleOfScreen, Quaternion.identity);
    modal.transform.parent = canvas.transform;
  }

  void LevelFail()
  {
    Vector3 middleOfScreen = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
    GameObject modal = Instantiate(successModal, middleOfScreen, Quaternion.identity);
    modal.transform.parent = canvas.transform;
  }


}
