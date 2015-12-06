using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public float loadNextLevelAfter;

    void Start() {
        if (loadNextLevelAfter > 0) {
            Invoke ("LoadNextLevel", loadNextLevelAfter);
        }
    }
	
	public void LoadLevel(string name) {
		Debug.Log ("name is "+name);
		Application.LoadLevel(name);
	}
	
	public void quitGame() {
		Debug.Log ("you now quit.");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
