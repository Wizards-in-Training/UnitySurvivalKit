using UnityEngine;
using System.Collections;


public class AutoDestroy : MonoBehaviour {

    public float lifespan = 1f;

	void Start () {
        // Auto destroy after a given time
        Destroy(gameObject, lifespan);
    }
}
