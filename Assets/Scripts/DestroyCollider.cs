using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollider : MonoBehaviour
{
    [SerializeField] GameObject playerSpawn;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.GetComponentInParent<DragAndDrop>() != null)
        {
            other.gameObject.GetComponentInParent<DragAndDrop>().ResetPosition();
        }
        else if (other.gameObject.GetComponentInParent<PlayerMovement>() != null)
        {
            other.gameObject.transform.position = playerSpawn.transform.position;
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
