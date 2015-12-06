using System.Collections;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float vol) {
        if (vol >= 0f && vol <= 1f) {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, vol);
        }
        else {
            Debug.LogError("Master volume value not allowed");
        }
    }

    public static float GetMasterVolume() {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level) {
        if (level <= Application.levelCount - 1) {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); //1 means level is unlocked
        }
        else {
            Debug.LogError("Level is not in build order");
        }
    }

    public static bool IsLevelUnlocked(int level) {
        if (level <= Application.levelCount - 1) {
            return PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()) == 1;
        }
        else {
            Debug.LogError("Level is not in build order");
        }
        return false;
    }

    public static void SetDifficulty(float diff) {
        if (diff >= 0f && diff <= 3f) {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, diff);
        }
        else {
            Debug.LogError("Difficulty value is not allowed");
        }
    }

    public static float GetDifficulty() {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }


}
