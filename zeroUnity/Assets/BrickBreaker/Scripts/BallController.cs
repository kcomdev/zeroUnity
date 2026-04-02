using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector2 initialDirection = new Vector2(Random.Range(-1f, 1f), 1).normalized;
        rb.linearVelocity = initialDirection * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
