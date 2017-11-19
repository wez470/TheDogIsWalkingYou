using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {
    public GameController gameController;

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag != "Background")
        {
            gameController.GameOver();
        }
    }
}
