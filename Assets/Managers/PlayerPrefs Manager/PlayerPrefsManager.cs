using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{

  const string UNLOCKED_LEVELS = "unlocked_levels";

  public int GetUnlockedLevels()
  {
    return PlayerPrefs.GetInt(UNLOCKED_LEVELS, 1);
  }

  public void SetUnlockedLevels(int levels)
  {
		PlayerPrefs.SetInt(UNLOCKED_LEVELS, levels);
  }
}
