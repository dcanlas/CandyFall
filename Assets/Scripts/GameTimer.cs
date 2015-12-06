using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    public float startSeconds = 100;
    public AudioClip beatLevelClip;

    private Slider slider;
    private LevelManager levelManager;
    private MusicManager musicManager;
    private GameObject winLabel;
    private bool levelEnded = false;


	// Use this for initialization
	void Start () {
	    slider = GetComponent<Slider>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        winLabel = GameObject.Find("You Win");
        if (winLabel) {
            winLabel.SetActive(false);
        }
        slider.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
        slider.value = Time.timeSinceLevelLoad / startSeconds;
        if (Time.timeSinceLevelLoad >= startSeconds && !levelEnded) {
            levelEnded = true;
            EndLevel();
        }
	}

    void EndLevel() {
        if (musicManager && beatLevelClip) {
            AudioSource audio = musicManager.GetComponent<AudioSource>();
            audio.clip = beatLevelClip;
            audio.loop = false;
            audio.Play();
        }
        winLabel.SetActive(true);
        Invoke("LoadNextLevel", beatLevelClip.length);
    }

    void LoadNextLevel() {
        levelManager.LoadNextLevel();
    }
}
