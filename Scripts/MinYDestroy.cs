using UnityEngine;
using System.Collections;


public class MinYDestroy : MonoBehaviour {

	// Set the minimum Y for the transform. This is useful for things you
	// wouldn't want to go below sea level, etc.
	float minY = 0f;

	void Update () {
	    if (transform.position.y <= minY) {
      	  Destroy(gameObject);
      }
	}
}
