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
    Rigidbody2D playerBody;
    Vector2 movementDirectionLR;
    float hMovement;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hMovement = Input.GetAxis("Horizontal") * moveSpeed;
        if((Input.GetKeyDown(KeyCode.Space)) && isGrounded()){
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpingPower);
        }
    }

    void FixedUpdate()
    {
        playerBody.velocity = new Vector2(hMovement*moveSpeed,playerBody.velocity.y);
    }

    bool isGrounded(){
        Debug.Log(groundCheck.position);
        Debug.Log(Physics2D.OverlapCircle(groundCheck.position, .5f, Ground));
        return Physics2D.OverlapCircle(groundCheck.position, .5f, Ground);
    }
}
