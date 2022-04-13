using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x * speed * Time.deltaTime, y * speed * Time.deltaTime);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
}
