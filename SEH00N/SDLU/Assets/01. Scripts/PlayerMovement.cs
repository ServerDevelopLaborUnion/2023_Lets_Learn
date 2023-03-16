using UnityEngine;

//player movement
//playermovement
//PlayerMovement

//내가 쓰는 방법
//character controller
//charactercontroller
//characterController

//c++ 교수님들 방법
//character controller
//charactercontroller
//_characterController

//퍼블릭 변수
//CharacterController

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Rigidbody2D rb2d = null;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 0 1

        rb2d.velocity = new Vector2(x * speed, rb2d.velocity.y);
        
        //a 키를 눌렀을 때 x -1 늘어날 거고
        //d 키를 눌렀을 x +1 늘어날 거야
    }
}
