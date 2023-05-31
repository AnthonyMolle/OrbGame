using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIQuitGame : MonoBehaviour
{

    [SerializeField] Button quitGame;

    // Start is called before the first frame update
    void Start()
    {
        // When the startGame button is pressed, then we want to add listener
        // that will listen for a particular method .
        quitGame.onClick.AddListener(RestartGame);
    }

    private void RestartGame()
    {
        ScenesManager.Instance.LoadMainMenu();
        // ScenesManager.Instance.LoadScene(ScenesManager.Scene.MainGameScene);
    }


}