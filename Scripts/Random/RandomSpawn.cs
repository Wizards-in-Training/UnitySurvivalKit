using UnityEngine;
using System.Collections;


public class RandomSpawn : MonoBehaviour {

    public GameObject spawnPrefab;
    public float rate = 10f;
    public float chance = 75f;

    private float min = 0f;
    private float max = 100f;

    void Start() {
        InvokeRepeating("CheckSpawn", 0f, rate);
    }

    void CheckSpawn() {
        // "roll" for the chance to spawn
        if (Random.Range(min, max) >= chance) {
            // Spawn the prefab
            Instantiate(spawnPrefab, transform.position, transform.rotation);
        }
    }
}