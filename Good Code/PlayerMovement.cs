using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float boostSpeed = 10f;
    public float movementLimit = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0f) * moveSpeed * Time.deltaTime;
        Vector2 newPosition = rb.position + movement;

        // Movement limitation
        newPosition.x = Mathf.Clamp(newPosition.x, -movementLimit, movementLimit);

        rb.MovePosition(newPosition);
    }

}
