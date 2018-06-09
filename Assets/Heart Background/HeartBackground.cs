using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartBackground : MonoBehaviour {

	[SerializeField] Sprite[] frames;

	public int framesPerSecond = 30;
	Image image;
	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		int i = (int) (Time.time * framesPerSecond) % frames.Length;
		image.sprite = frames[i];
	}
}
