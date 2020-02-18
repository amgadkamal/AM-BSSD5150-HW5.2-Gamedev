using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerB : MonoBehaviour
{
    private float move;
    private float move2;
    private float maxSpeed = 5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        move2 = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move * maxSpeed, move2 * maxSpeed);
    }

    private void OncollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(0, 300), ForceMode2D.Impulse);
    }
    
}
