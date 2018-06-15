using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    [SerializeField] float readingTime = 1f;
    [SerializeField] float fadingTime = 3f;
    [SerializeField] GameObject startAgainButton;

    PlayerPrefsManager playerPrefsManager;
    Text text;
    Color textColor;
    string[] sentences;

    void Start () {
        playerPrefsManager = FindObjectOfType<PlayerPrefsManager> ();
        text = GetComponent<Text> ();
        textColor = text.color;
        sentences = Constants.sentences;
        StartCoroutine (ShowSentences ());
    }

    IEnumerator ShowSentences () {
        for (int i = 0; i < sentences.Length; i++) {
            text.text = sentences[i];
            float t = 0f;
            while (t < fadingTime) {
                textColor.a = t;
                text.color = textColor;
                t += Time.deltaTime;
                yield return new WaitForEndOfFrame ();
            }
            yield return new WaitForSeconds (readingTime);
            while (t > 0f) {
                textColor.a = t;
                text.color = textColor;
                t -= Time.deltaTime;
                yield return new WaitForEndOfFrame ();
            }
        }
        StartCoroutine (ShowStartAgainButton ());
    }

    IEnumerator ShowStartAgainButton () {
        startAgainButton.SetActive(true);
        Text startAgainText = startAgainButton.GetComponentInChildren<Text>();
        float t = 0f;
        while (t < fadingTime) {
            textColor.a = t;
            startAgainText.color = textColor;
            t += Time.deltaTime;
            yield return new WaitForEndOfFrame ();
        }
    }

    public void StartAgain () {
        playerPrefsManager.SetUnlockedLevels (1);
        LevelLoader loader = new LevelLoader ();
        loader.LoadLevel (0);
    }
}