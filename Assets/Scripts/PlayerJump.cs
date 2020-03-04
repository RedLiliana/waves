using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float speed;
    public float jump;
    float moveVelocity;
 
    [Range(1, 10)]
    public float jumpVelocity;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
         //isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*if( Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
        }*/
        

   

    // Update is called once per frame
    
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            //GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
        }
    }

    //private bool isGrounded;
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("touched ground");
        isGrounded = true;
    }
    /*void OnCollisionStay(Collision coll)
    {
        isGrounded = true;
    }*/
    void OnCollisionExit2D(Collision2D coll)
    {
        if (isGrounded)
        {
            isGrounded = false;
        }
    }
}

