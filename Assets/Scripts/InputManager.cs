using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical"); // y��
        float horizontal = Input.GetAxisRaw("Horizontal"); // x��

        Vector2 direction = new Vector2(horizontal, vertical);

        direction = direction.normalized;

        rb.velocity = direction * speed;
    }
}
