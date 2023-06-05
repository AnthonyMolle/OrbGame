using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    bool held = false;
    bool positionReset = false;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject spawnPoint;

    private void Start() 
    {
        ResetPosition();    
    }

    private void FixedUpdate() 
    {
        if (held || positionReset)
        {
            rb.velocity = new Vector2(0, 0);
            if (positionReset)
            {
                positionReset = false;
            }
        }    
    }

    private void Update() 
    {
        if (!Input.GetKey(KeyCode.Mouse0))
        {
            held = false;
        }
        else
        {
            held = true;
        }

        if (held)
        {
            gameObject.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    // private void OnMouseOver() 
    // {
    //     Debug.Log("mouse over");
    //     if (Input.GetKeyDown(KeyCode.Mouse0))
    //     {
    //         Debug.Log("mouse clicked");
    //         held = true;
    //     }
    // }

    public void ResetPosition()
    {
        gameObject.transform.position = spawnPoint.transform.position;
        positionReset = true;
    }
}
