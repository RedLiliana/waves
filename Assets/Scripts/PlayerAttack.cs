using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] int attackDamage;
    [SerializeField] float attackRadius;

    private void Update()
    {
        //Collider2D[] info = new Collider2D[Physics2D.OverlapCircleAll(transform.position + transform.right, attackRadius).Length];
        //Collider2D[]  info = Physics2D.OverlapCircleAll(transform.position + transform.right, attackRadius);


        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Pressed left mouse click");
            Collider2D[] info = Physics2D.OverlapCircleAll(transform.position + transform.right, attackRadius);
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i].tag == "Enemy")
                {
                    Debug.Log("hit:" + info[i].name);
                    info[i].GetComponent<Health>().health -= attackDamage;
                    Debug.Log("Enemy health is:" +  info[i].GetComponent<Health>().health);

                    if (info[i].GetComponent<Health>().health <= 0)
                    {
                        Destroy(info[i].gameObject);
                    }
                }
            }

        }


          



        /*for (int i = 0; i < info.Length; i++)
        {
            if(Input.GetKey(KeyCode.Mouse1) && info[i].tag == "Enemy")
            {
                info[i].GetComponent<Health>().health -= attackDamage;
                Debug.Log(info[i].GetComponent<Health>().health);

                if(info[i].GetComponent<Health>().health <= 0)
                {
                    Destroy(info[i].gameObject);
                }
            }
        }*/
    }

}
