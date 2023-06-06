using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class AutoScroll : MonoBehaviour
{
    
    float textPoseBegin = -680.0f;
    float boundaryTextEnd = 865.0f;

    RectTransform myGorectTransform;

    [SerializeField]
    float speed = 140.0f;

    [SerializeField]
    TextMeshProUGUI mainText;

    // Start is called before the first frame update
    void Start()
    {
        myGorectTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(AutoScrollerText());
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    IEnumerator AutoScrollerText() {
        while(myGorectTransform.localPosition.y<boundaryTextEnd) {
            myGorectTransform.Translate(Vector3.up*speed*Time.deltaTime);
            yield return null;
        }

        if (myGorectTransform.localPosition.y>boundaryTextEnd) {
            SceneManager.LoadScene("MainMenu");
            // yield return null;
        }

        
    }
}
