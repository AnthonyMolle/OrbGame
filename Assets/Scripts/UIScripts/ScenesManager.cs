using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public static ScenesManager Instance;

    private void Awake()
    {
        // instance is equal to this class
        Instance = this;
        
    }

    // When adding new scenes:
    // 1. Add to the enumerator list below
    // 2. Add to File -> build settings in the correct order as shown there
    public enum Scene
    {
        Lynelle2,
        MainGameScene
    }

    public void LoadScene(Scene scene)
    {
        // To string because the scene is currently enum and needs to be a string.
        SceneManager.LoadScene(scene.ToString());
    }

    // A function to load the main game scene.
    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.MainGameScene.ToString());
    }

    // A function to load the next scene in the game.

    public void LoadNextScene()
    {
        // Loads the next scene in the build settings index. 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Loads the main menu scene.
    // ** Lynelle2 can be renamed/replaced
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.Lynelle2.ToString());
    }
}
