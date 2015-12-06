using System.Collections;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
	    levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider) {
            levelManager.LoadLevel("03_Lose");
        }
    }
}
