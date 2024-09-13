using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musuh : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        speed = -speed;
        Flip();
    }

    private void Flip()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), 1f);
    }
}
