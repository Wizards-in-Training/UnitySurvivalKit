using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour {

    // Determines the location that the projectile will be instantiated.
    public GameObject spawnPosition;

    // The projectile prefab.
    public GameObject spawnPrefab;

    // How much for to apply to the RigidBody
    public float fireForce = 500f;

    // The sound clip to play when firing the projectile
    public AudioClip fireSound;

    void Fire() {
        // Instantiate the prefab, and fire the projectile by calling AddFOrce on the RigidBody
        GameObject projectile = (GameObject)Instantiate(spawnPrefab, spawnPosition.transform.position, spawnPosition.transform.rotation);
        projectile.GetComponent<Rigidbody>().AddForce(spawnPosition.transform.forward * fireForce);

        // Play the fire sound effect.
        GetComponent<AudioSource>().PlayOneShot(fireSound);
    }
}
