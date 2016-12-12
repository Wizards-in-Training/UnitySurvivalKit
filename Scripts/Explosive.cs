using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Explosive : MonoBehaviour {

    // A common pattern would be to combine particle effect, and audio in the explosion prefab.
    public GameObject explosionPrefab;

    void OnCollisionEnter() {
        // Destroy the explosive when it collides with any other rigid body.
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
