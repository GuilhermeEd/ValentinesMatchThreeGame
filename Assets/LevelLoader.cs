using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	[SerializeField] int level = 1;

	public void LoadLevel() {
		SceneManager.LoadScene(level);
	}
}
