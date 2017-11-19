using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    private BoxCollider2D boxCollider;
    private Rigidbody2D rigidbody2D;
    private bool grounded = false;
    public float maxSpeed = 10f;
    public float jumpForce = 800f;

    // Use this for initialization
    void Start () {
        boxCollider = GetComponent<BoxCollider2D>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
        }
    }

    // FixedUpdate is called at a set rate
    void FixedUpdate()
    {

       // grounded = boxCollider.IsTouching();
        if (grounded)
        {
            grounded = true;
        }

        float move = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2(maxSpeed * move, rigidbody2D.velocity.y);
    }
}
