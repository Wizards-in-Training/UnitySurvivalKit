using UnityEngine;
using System.Collections;


public class RandomAudio : MonoBehaviour {

    public AudioClip[] audioClips;
    public float rate = 1f;
    public float chance = 1f;

    protected float min = 0f;
    protected float max = 100f;


    void Start() {
        InvokeRepeating("PlaySound", rate, rate);
    }

    void PlaySound() {
        if (Random.Range(min, max) <= chance) {
            AudioClip clip = audioClips[Random.Range(0, audioClips.Length - 1)];
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }

}
