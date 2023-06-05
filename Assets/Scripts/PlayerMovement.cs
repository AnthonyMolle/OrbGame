using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 5;
    [SerializeField] float jumpingPower = 15;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask Ground;
    [SerializeField] GameObject spawnPoint;
    Rigidbody2D playerBody;
    [SerializeField] public Animator animator;
    Vector2 movementDirectionLR;
    [SerializeField] public bool facingRight;
    float hMovement;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hMovement = Input.GetAxis("Horizontal") * moveSpeed;
        animator.SetFloat("MoveSpeed", Mathf.Abs(hMovement));
        if((Input.GetKeyDown(KeyCode.Space)) && isGrounded()){
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpingPower);
            //animator.SetBool("IsJumping", true);
        }

        Debug.Log(playerBody.velocity.y);

        if(playerBody.velocity.y > .1f){
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
        if(playerBody.velocity.y == 0){
           animator.SetBool("IsJumping", false);
        }
        Flip();
    }

    void FixedUpdate()
    {
        playerBody.velocity = new Vector2(hMovement*moveSpeed,playerBody.velocity.y);
    }

    bool isGrounded(){
        Debug.Log(groundCheck.position);
        Debug.Log(Physics2D.OverlapCircle(groundCheck.position, .5f, Ground));

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, .5f, Ground);

        if (colliders.Length > 0)
        {
            foreach (Collider2D collider in colliders)
            {
                if (collider.isTrigger == false)
                {
                    return true;
                }
            }

            return false;
        }
        else
        {
            return false;
        }
    }

    public void ResetPlayer()
    {
        gameObject.transform.position = spawnPoint.transform.position;
    }

    void Flip(){
        if((hMovement < 0 && facingRight) || (hMovement > 0 && !facingRight))
        {
            facingRight = !facingRight;
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }
}
