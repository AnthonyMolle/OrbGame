using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoScroll : MonoBehaviour
{
    float speed = 80.0f;
    float textPoseBegin = -680.0f;
    float boundaryTextEnd = 865.0f;

    RectTransform myGorectTransform;
    [SerializeField]
    TextMeshProUGUI mainText;

    [SerializeField]
    bool isLooping = false;

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
    }
}
