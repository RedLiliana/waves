using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
          Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Enemy")
        {

            collision.gameObject.GetComponent<EnemyPatrol>().EnemyDirection = -collision.gameObject.GetComponent<EnemyPatrol>().EnemyDirection;

          //  Vector2 dir = collision.gameObject.GetComponent<EnemyPatrol>().EnemyDirection;
            //dir = -dir;
        }
    }
}
