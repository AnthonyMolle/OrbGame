using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            other.gameObject.GetComponent<PlayerMovement>().ResetPlayer();
        }
    }
}
