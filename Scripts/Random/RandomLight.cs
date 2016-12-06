using UnityEngine;
using System.Collections;

public class RandomLight : MonoBehaviour {

    public float rate = 1f;
    public float chance = 1f;

    protected float min = 0f;
    protected float max = 100f;

    void Start() {
        InvokeRepeating("ToggleLight", rate, rate);
    }

    void ToggleLight() {
        if (Random.Range(min, max) <= chance) {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
