using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour {
    private GameObject gameOverMenu;

    // Use this for initialization
    void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameObject.FindGameObjectWithTag("GameOverMenu"))
        {
            Vector3 newPosition = transform.position;
            newPosition.x -= 0.05f;
            transform.position = newPosition;
        }
	}

    void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
