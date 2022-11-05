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
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("xForce: " + xForce);
        Debug.Log("yForce: " + yForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LeftWall")
        {
            Vector2 jumpForce = new Vector2(xForce, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }

        if (collision.gameObject.tag == "RightWall")
        {
            //enemyRigidbody.velocity.x*-1*xForce means that the enemyRigidbody.velocity.xForce becomes a negative number
            Vector2 jumpForce = new Vector2(enemyRigidbody.velocity.x*-1*xForce, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }

        if(collision.gameObject.tag == "TopWall")
        {
            Vector2 jumpForce = new Vector2(-xForce, enemyRigidbody.velocity.y * -1 * yForce);
            enemyRigidbody.AddForce(jumpForce);
        }
    }
}
