using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerA : MonoBehaviour
{
    
   
    private Rigidbody2D rb;
    // Start is called before the first frame update

    private bool mousee;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMouseDown()
    {
        mousee= true;
    }

    public void OnMouseUp()
    {
        mousee= false;
    }
    // Update is called once per frame
    void Update()
    {
        if (mousee)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }

    private void OncollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(0, 300), ForceMode2D.Impulse);
    }
}