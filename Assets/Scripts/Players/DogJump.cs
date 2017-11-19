using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogJump : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Rigidbody2D rigidbody2D;
    private bool grounded = false;
    public float maxSpeed = 10f;
    public float jumpForce = 800f;

    // Use this for initialization
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
        }
    }

    // FixedUpdate is called at a set rate
    void FixedUpdate()
    {
        GameObject[] backgrounds = GameObject.FindGameObjectsWithTag("Background");
        grounded = false;
        foreach (GameObject background in backgrounds)
        {
            grounded |= boxCollider.IsTouching(background.GetComponent<BoxCollider2D>());
        }
    }
}
