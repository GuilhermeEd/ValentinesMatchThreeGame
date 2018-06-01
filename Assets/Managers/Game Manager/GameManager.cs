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
    PlayerPrefsManager playerPrefsManager;
    LevelManager levelManager;

    void Start()
    {
        timer = FindObjectOfType<Timer>();
        levelManager = FindObjectOfType<LevelManager>();
        playerPrefsManager = FindObjectOfType<PlayerPrefsManager>();
    }

    public void OnTimeUp()
    {
        timer.Stop();
        Vector3 middleOfScreen = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        GameObject modal = Instantiate(failModal, middleOfScreen, Quaternion.identity);
        modal.transform.SetParent(canvas.transform);
    }

    public void OnLevelSuccess()
    {
        timer.Stop();
        Vector3 middleOfScreen = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        GameObject modal = Instantiate(successModal, middleOfScreen, Quaternion.identity);
        modal.transform.SetParent(canvas.transform);
        playerPrefsManager.SetUnlockedLevels(levelManager.GetCurrentLevel() + 1);
    }

    public void StartGame()
    {
        gameStarted = true;
        timer.Init();
    }

}
