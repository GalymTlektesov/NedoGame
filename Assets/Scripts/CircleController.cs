using UnityEngine;
using UnityEngine.UI;

public class CircleController : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public Text text;
    int points = 0;
    public GameObject platform;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<WhitePlatformController>() != null )
        {
            points++;
            rigidbody.velocity = new Vector2(Random.Range(-10.0f, 10.0f), rigidbody.velocity.y);
            text.text = points.ToString();
        }


        PlatCol("PlatformWhiteSprite (4)", Random.Range(-10.0f, 10.0f), rigidbody.velocity.y, collision);
        PlatCol("PlatformWhiteSprite (2)", rigidbody.velocity.x, Random.Range(-5.0f, 5.0f), collision);
        PlatCol("PlatformWhiteSprite (3)", rigidbody.velocity.x, Random.Range(-5.0f, 5.0f), collision);
        Lose("PlatformWhiteSprite (1)", collision);
    }
    private void Lose(string name, Collision2D collision)
    {
        if(collision.gameObject.name== name)
        {
            Destroy(gameObject);
            Destroy(platform);
            text.text = "Вы проебали!";
        }

    }

    private void PlatCol(string name, float x, float y, Collision2D collision)
    {
        if (collision.gameObject.name == name)
        {
            rigidbody.velocity = new Vector2(x, y);
        }
    }
}
