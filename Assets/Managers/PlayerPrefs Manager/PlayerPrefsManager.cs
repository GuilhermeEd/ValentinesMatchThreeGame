using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    private static PlayerPrefsManager singleton;
    const string UNLOCKED_LEVELS = "unlocked_levels";

    void Awake()
    {
        // SetUnlockedLevels(5);
        if (singleton)
        {
            Destroy(gameObject);
        }
        else
        {
            singleton = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetUnlockedLevels()
    {
        return PlayerPrefs.GetInt(UNLOCKED_LEVELS, 1);
    }

    public void SetUnlockedLevels(int levels)
    {
        PlayerPrefs.SetInt(UNLOCKED_LEVELS, levels);
    }

    public bool IsLevelUnlocked(int level)
    {
        return GetUnlockedLevels() >= level;
    }
}
