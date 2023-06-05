using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] LevelLoaderScript levelLoader;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            Destroy(other.gameObject);
            anim.Play("Level Transition");
        }    
    }

    public void NextScene()
    {
        levelLoader.LoadNextLevel();
    }
}
