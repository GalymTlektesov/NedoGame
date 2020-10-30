using UnityEngine;

public class WhitePlatformController : MonoBehaviour
{
    public float maxSpeed = 10f;
    public Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moving = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(moving * maxSpeed, rigidbody.velocity.y);
    }
}
