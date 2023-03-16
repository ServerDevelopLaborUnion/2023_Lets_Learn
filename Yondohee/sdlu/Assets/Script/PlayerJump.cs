using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb = null;
    [SerializeField] float power = 0f;
    [SerializeField] float rayDistance = 0.6f;
    void PJump(){
        if(CanJump())
            rb.AddForce(Vector2.up*power);
    }
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            PJump();
        }
    }
    private bool CanJump(){
        return Physics2D.Raycast(transform.position, Vector2.down, rayDistance, 1 << 6);
    }
    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * rayDistance);
    }
}