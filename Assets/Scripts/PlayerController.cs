
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7f;
    float halfScreenWight;
    float wightPlayer;
    // Start is called before the first frame update
    void Start()
    {
        wightPlayer = transform.localScale.x;
        halfScreenWight = Camera.main.aspect * Camera.main.orthographicSize - wightPlayer / 2f;

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector2 velocity = Vector2.right * inputX * speed;
        transform.Translate(velocity * Time.deltaTime);
        if (transform.position.x > halfScreenWight)
            transform.position = new Vector2(halfScreenWight, transform.position.y);
        if (transform.position.x < -halfScreenWight)
            transform.position = new Vector2(-halfScreenWight, transform.position.y);
    }
}