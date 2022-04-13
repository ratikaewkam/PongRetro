using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayerController : MonoBehaviour
{
    public float speed;
    private float movement;
    private Rigidbody2D rb;
    private Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical2");
        rb.velocity = new Vector2(rb.velocity.x, movement * speed * Time.deltaTime);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
