using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 1;
    public float distance = 10;

    private bool movingRight = true;

    public Transform groundDetection;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;
    public Vector2 EnemyDirection = new Vector2(1,0);

    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(EnemyDirection * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        //hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        if (hittingWall)
        {
            movingRight = !movingRight;
        }

        

    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Enemy")
        {

            collision.gameObject.GetComponent<EnemyPatrol>().EnemyDirection = -collision.gameObject.GetComponent<EnemyPatrol>().EnemyDirection;

            //  Vector2 dir = collision.gameObject.GetComponent<EnemyPatrol>().EnemyDirection;
            //dir = -dir;
        }
    }*/
}
