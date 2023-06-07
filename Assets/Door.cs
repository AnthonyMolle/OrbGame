using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] ScenesManager levelLoader;

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
        levelLoader.LoadNextScene();
    }
}
