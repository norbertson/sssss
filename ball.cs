using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool changeDirection = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (rb.velocity.y <= Mathf.Epsilon)
        {
            changeDirection = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (changeDirection)
        {
            Debug.Log("Adding vertical force to ball");
            Vector2 randomForce = new Vector2(0, Random.Range(-1, 1));
            rb.AddForce(randomForce);
        }
    

        }
    }

