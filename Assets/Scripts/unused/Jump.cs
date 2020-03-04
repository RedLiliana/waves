using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    bool isGrounded;

    void Start() { isGrounded = true; }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Jump") && isGrounded == true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
        }
    }

    //private bool isGrounded;

    void OnCollisionStay(Collision coll)
    {
        isGrounded = true;
    }
    void OnCollisionExit(Collision coll)
    {
        if (isGrounded)
        {
            isGrounded = false;
        }
    }
}
