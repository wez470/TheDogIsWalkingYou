using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusScoreUpdater : MonoBehaviour {
    private Score score;
	// Use this for initialization
	void Start () {
        this.score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit2D(Collider2D coll) {
        score.UpdateScore();
    }
}
