using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICredits : MonoBehaviour
{

    [SerializeField] Button goCredits;

    // Start is called before the first frame update
    void Start()
    {
        // When the startGame button is pressed, then we want to add listener
        // that will listen for a particular method .
        goCredits.onClick.AddListener(LoadCredits);
    }

    private void LoadCredits()
    {
        //ScenesManager.Instance.LoadMainMenu();
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Credits);
    }


}
