using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] float speedX, speedY;
    [SerializeField] float moveSpeed;
    [SerializeField] Animator playerAni;

    // verificadores de movimiento
    public bool isXmoving;
    public bool isYmoving;

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;

        if (speedX > 0)
        {
            speedX = moveSpeed;
            speedY = 0;
        }
        if (speedX < 0)
        {
            speedX = -moveSpeed;
            speedY = 0;
        }
        if (speedY < 0)
        {
            speedY = -moveSpeed;
            speedX = 0;
        }
        if (speedY > 0)
        {
            speedY = moveSpeed;
            speedX = 0;
        }

        rb2D.linearVelocity = new Vector2 (speedX, speedY);

        playerAni.SetFloat("speedx", speedX);
        playerAni.SetFloat("speedy", speedY);
    }
}
