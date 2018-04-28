using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

  [SerializeField] float totalTime = 60;
  [SerializeField] float timeLeft = 60;
  [SerializeField] Color startTimeColor = Color.green;
  [SerializeField] Color endTimeColor = Color.red;

  Slider slider;
  GameObject sliderFill;
  Image sliderFillimage;
  GameManager gameManager;


  // Use this for initialization
  void Start()
  {
    slider = GetComponentInChildren<Slider>();

    sliderFill = slider.transform.Find("Fill Area").Find("Fill").gameObject;
    sliderFillimage = sliderFill.GetComponent<Image>();
    sliderFillimage.color = startTimeColor;

    gameManager = GameObject.FindObjectOfType<GameManager>();

    StartCoroutine("Countdown");
  }

  IEnumerator Countdown()
  {
    while (true)
    {
      yield return new WaitForSeconds(1);
      timeLeft -= 1f;
      slider.value = timeLeft / totalTime;
      sliderFillimage.color = Color.Lerp(endTimeColor, startTimeColor, slider.value);
      if (timeLeft < 0f)
      {
        StopCoroutine("Countdown");
        Destroy(sliderFill);
        gameManager.OnTimeUp();
      }
    }
  }

  public void Reset()
  {
    timeLeft = totalTime;
  }
}
