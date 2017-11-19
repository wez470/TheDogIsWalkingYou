using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour {
    public GameController gameController;

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag != "Background")
        {
            gameController.GameOver();
        }
    }
}
