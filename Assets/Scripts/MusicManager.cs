using System.Collections;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] musicChange;

    private AudioSource audioSource;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
	}

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }
	
	void OnLevelWasLoaded (int level) {
        if (level < musicChange.Length) {
            AudioClip clip = musicChange[level];

            if (clip) {
                audioSource.clip = clip;
                audioSource.loop = true;
                audioSource.Play();
            }
        }

	}

    public void ChangeVolume(float vol) {
        audioSource.volume = vol;
    }
}
