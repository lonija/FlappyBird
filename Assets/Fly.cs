using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float roationSpeed = 10f;
    private Rigidbody2D rb;

   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }

    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * roationSpeed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();

    }
}