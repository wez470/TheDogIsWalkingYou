using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leash : MonoBehaviour {
    public Transform DogHand;
    public Transform HumanCollar;

	void Start () {}
	
	void Update () {
        setPosition();
        setScale();
        setRotation();
	}

    private void setPosition() {
        transform.position = (DogHand.position + HumanCollar.position) / 2;
    }

    private void setScale() {
        float yScale = Vector3.Distance(DogHand.transform.position, HumanCollar.position);
        Vector3 scale = transform.localScale;
        scale.y = yScale;
        transform.localScale = scale;
    }

    private void setRotation() {
        Vector3 rotation = DogHand.position - HumanCollar.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        Quaternion.Euler(new Vector3(0, 0, rotZ));
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotZ + 90));
    }
}