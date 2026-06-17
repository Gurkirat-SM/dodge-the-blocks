using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(move * speed, 0);
    }
}