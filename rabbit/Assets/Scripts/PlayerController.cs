using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 15f;
    public float runSpeed = 1.0f;
    private Rigidbody2D rb;
    public LayerMask groundMask;
    public Animator animator;
    public static PlayerController sharedInstance;
    private Vector3 startPosition;
    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sharedInstance = this;
        startPosition = transform.position;
        animator.SetBool("isAlive", true);
    }
    // Start is called before the first frame update
    public void StartGame()
    {
        rb.velocity = new Vector2(0, 0);
        animator.SetBool("isAlive", true);
        transform.position = startPosition;
    }
    private void FixedUpdate()
    {
        if (GameManager.sharedInstance.currentGameState != GameState.inTheGame)
        {
            return;
        }
        if (this.rb.velocity.x < this.runSpeed)
        {
            this.rb.velocity = new Vector2(runSpeed, this.rb.velocity.y);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(GameManager.sharedInstance.currentGameState != GameState.inTheGame)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            bool isGrounded = IsOnTheFloor();

            if(isGrounded)
                Jump();
            animator.SetBool("isGrounded", isGrounded);
        }
    }
    private void Jump()
    {
       
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    bool IsOnTheFloor()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 0.9f, groundMask.value))
            return true;
        else return false;
        
      //  return res.collider != null ? true: false;
          
    }
   public void KillPlayer()
    {
        GameManager.sharedInstance.GameOver();
        animator.SetBool("isAlive", false);

    }
}

