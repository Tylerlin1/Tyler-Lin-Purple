using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    private Rigidbody2D enemyRigidbody;
    public int maximumXPosition;
    public int minimumXPosition;
    public bool direction;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }
        if(collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Exit").GetComponent<Teleport>().enemyCount--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*        if (collision.gameObject.tag == "LeftWall")
                {
                    Vector2 jumpForce = new Vector2(xForce, yForce);
                    enemyRigidbody.AddForce(jumpForce);
                }*/
        if (collision.gameObject.tag == "LeftWall")
        {
            if (direction == true)
            {
                Vector2 jumpForce = new Vector2(xForce = 140, yForce);
                enemyRigidbody.AddForce(jumpForce);
                enemyRigidbody.velocity = new Vector2(0, enemyRigidbody.velocity.y);
                direction = false;
            }
        }

        if (collision.gameObject.tag == "RightWall")
        {
            /*            //enemyRigidbody.velocity.x*-1*xForce means that the enemyRigidbody.velocity.xForce becomes a negative number
                        Vector2 jumpForce = new Vector2(enemyRigidbody.velocity.x * -1 * xForce, yForce);
                        enemyRigidbody.AddForce(jumpForce);*/
            if (direction == false)
            {
                Vector2 jumpForce = new Vector2(xForce = -140, yForce);
                enemyRigidbody.AddForce(jumpForce);
                enemyRigidbody.velocity = new Vector2(0, enemyRigidbody.velocity.y);
                direction = true;
            }
        }
        if (collision.gameObject.tag == "TopWall")
        {
            Vector2 jumpForce = new Vector2(-xForce, enemyRigidbody.velocity.y * -1 * yForce);
            enemyRigidbody.AddForce(jumpForce);
        } 
    }
}
