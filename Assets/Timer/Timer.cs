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
  bool isCounting = false;

  // Use this for initialization
  void Start()
  {
    slider = GetComponentInChildren<Slider>();

    sliderFill = slider.transform.Find("Fill Area").Find("Fill").gameObject;
    sliderFillimage = sliderFill.GetComponent<Image>();
    sliderFillimage.color = startTimeColor;

    gameManager = GameObject.FindObjectOfType<GameManager>();

  }

  void Update()
  {
    if (isCounting) Tick();
  }

  void Tick()
  {
    timeLeft -= Time.deltaTime;
    sliderFillimage.color = Color.Lerp(endTimeColor, startTimeColor, slider.value);
    slider.value = timeLeft / totalTime;
    if (timeLeft <= 0f)
    {
      Stop();
      Destroy(sliderFill);
      gameManager.OnTimeUp();
    }
  }

  public void Init()
  {
    isCounting = true;
  }

  public void Stop()
  {
    isCounting = false;
  }

  public void Reset()
  {
    timeLeft = totalTime;
  }
}
