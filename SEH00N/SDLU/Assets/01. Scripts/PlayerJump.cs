using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] float jumpPwr = 10f;
    [SerializeField] float rayDistance = 0.6f;
    private Rigidbody2D rb2d = null;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            if(CanJump())
                Jump();
    }

    private void Jump()
    {
        rb2d.AddForce(Vector2.up * jumpPwr, ForceMode2D.Impulse);
    }

    private bool CanJump()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, rayDistance, 1 << 6);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * rayDistance);
    }
}
