using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{

    [SerializeField] Button startGame;
    [SerializeField] ScenesManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        // When the startGame button is pressed, then we want to add listener
        // that will listen for a particular method .
        startGame.onClick.AddListener(StartNewGame);
    }

    private void StartNewGame()
    {
        levelManager.LoadNextScene();
        // ScenesManager.Instance.LoadScene(ScenesManager.Scene.MainGameScene);
    }


}
