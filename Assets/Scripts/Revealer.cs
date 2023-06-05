using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revealer : MonoBehaviour
{

    [SerializeField] string revealedLayerString;
    [SerializeField] string hiddenLayerString;

    int hiddenLayer;
    int revealedLayer;

    private void Start() 
    {
        hiddenLayer = LayerMask.NameToLayer(hiddenLayerString);
        revealedLayer = LayerMask.NameToLayer(revealedLayerString);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.layer == revealedLayer)
        {
            other.isTrigger = true;
        }

        if (other.gameObject.layer == hiddenLayer)
        {
            other.isTrigger = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.layer == revealedLayer)
        {
            other.isTrigger = false;
        }

        if (other.gameObject.layer == hiddenLayer)
        {
            other.isTrigger = true;
        }
    }
}
